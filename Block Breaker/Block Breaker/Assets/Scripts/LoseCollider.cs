using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        this.tag = "LoseCollider";
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision detected!");

        if (collision.gameObject.CompareTag("Ball"))
        {
            levelManager.loadLevel("Lose");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        print("Trigger detected! " + collider.gameObject.name);
        if (collider.gameObject.name.Equals("Ball"))
        {
            levelManager.loadLevel("Lose");
        }
    }

}
