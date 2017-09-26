using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Paddle paddle;
    private Vector3 paddleToBall;
    private Rigidbody2D mRigidBody2D;
    private bool hasStarted = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();

        paddleToBall = this.transform.position - paddle.transform.position;
        mRigidBody2D = GetComponent<Rigidbody2D>();
        hasStarted = false;

        this.tag = "Ball";
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBall;

            if (Input.GetMouseButton(0))
            {
                hasStarted = true;
                print("mouse clicked!");
                //rigidbody2D.velocity = new Vector2(0.5f, 10.0f);
                mRigidBody2D.velocity = new Vector2(2.5f, 10.0f);
            }
        }
    }
}
