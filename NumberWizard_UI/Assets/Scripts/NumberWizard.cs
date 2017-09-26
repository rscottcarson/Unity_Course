using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

private int min;
private int max;
private int guess;

    public int maxGuessesAllowed = 5;

    public Text mText;

	// Use this for initialization
	void Start () {
		StartGame();
	}

    public void guessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void guessLower()
    {
        max = guess;
        NextGuess();
    }

    
	
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		max++;

        NextGuess();
	}
	
	void NextGuess()
	{
		guess = Random.Range(min, max+1);

        mText.text = guess.ToString();

        maxGuessesAllowed--;

        if(maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
	}
}
