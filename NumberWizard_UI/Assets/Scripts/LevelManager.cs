using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void loadLevel(string name)
    {
        print("Loading level " + name);
        Application.LoadLevel(name);
    }

    public void quitRequest()
    {
        print("Quit");
        Application.Quit();
    }
}
