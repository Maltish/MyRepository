using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplication : MonoBehaviour {
    int randomInt;
    int randomInt2;

    public Text myText;
    // Use this for initialization
    void Start () {
        randomInt = Random.Range(1, 11);
        randomInt2 = Random.Range(1, 11);

        myText.text = "What is "+randomInt+"*"+randomInt2+"?";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
