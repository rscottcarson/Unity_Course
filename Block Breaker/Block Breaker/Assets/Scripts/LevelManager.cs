using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void loadLevel(string name)
    {
        print("Loading level " + name);
        SceneManager.LoadScene(name);
    }

    public void quitRequest()
    {
        print("Quit");
        Application.Quit();
    }

    public void loadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
