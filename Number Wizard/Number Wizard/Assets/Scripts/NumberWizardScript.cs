using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess = 500;

    // Use this for initialization
    void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("The number is higher");
            min = guess + 1;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("The number is lower");
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("You guessed the number " + guess + " correctly!");
            print("I won! :)");
            StartGame();
        }
    }

    void NextGuess()
    {
        //guess = (min + max) / 2;
        System.Random rand = new System.Random();
        guess = rand.Next(min, (max + 1));
        print("Is the number higher,lower or equal to" + guess + "?");
        print("Higher: UP arrow, Lower: DOWN arrow, Equal: ENTER");
    }
    void StartGame()
    {
        min = 1;
        max = 1000;


        print("Welcome to Number Wizard!");
        print("Pick a number between 1 and 1000!!!!!!");


        NextGuess();
    }
}
