using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer sInstance = null;

    void Awake()
    {
        if (sInstance == null)
        {
            sInstance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
        else {
            print("Destroying duplicate instance!");
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
