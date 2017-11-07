using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncDecScript : MonoBehaviour {
    int num = 50;
    // Use this for initialization
    void Start () {
        print("Press Down arrow to decremenet the number or UP arrow to increment the number. To exit the program, press the Enter key.");
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            num--;
            print("Down arrow key pressed! The number has been decremented to: "+ num);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            num++;
            print("Up arrow key pressed! The number has been incremented to: " + num);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Exiting program");
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
