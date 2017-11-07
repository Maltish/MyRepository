using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {


    public Text compGuess;

    int min = 1;
    int max = 1000;
    int guess = 500;
    int maxGuesses = 5;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    // Update is called once per frame
    void Update () {
    }

    void NextGuess()
    {
        if(maxGuesses > 0)
        {
            //guess = (min + max) / 2;
            System.Random rand = new System.Random();
            guess = rand.Next(min, (max + 1));
            compGuess.text = guess + "?";
            maxGuesses--;
        }
        else
        {
            SceneManager.LoadScene("Win");
        }
       
    }
    void StartGame()
    {
        min = 1;
        max = 1000;




        NextGuess();
    }
}
