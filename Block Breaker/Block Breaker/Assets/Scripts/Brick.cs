using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public int hitsToDestroy;

    private Rigidbody2D mRigidBody;
    private int numHits;
    private LevelManager mLevelManager;

	// Use this for initialization
	void Start () {
        mLevelManager = GameObject.FindObjectOfType<LevelManager>();
        mRigidBody = GetComponent<Rigidbody2D>();
        this.tag = "Brick";
        numHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.name.Equals("Ball"))
        //{
        //    mRigidBody.gravityScale = 1.0f;
        //    mRigidBody.isKinematic = false;
        //}
        numHits++;
        if(numHits >= hitsToDestroy)
        {
            //SimulateWin();
            Destroy(gameObject);
        }
    }

    // TODO
    void SimulateWin()
    {
        mLevelManager.loadNextlevel();
    }
}
