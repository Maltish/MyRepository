using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.mousePosition.x);


        Vector3 newPaddlePos = new Vector3(Input.mousePosition.x, th.transform.position.y, this.transform.position.z);
        
       // this.transform.position = 
	}
}
