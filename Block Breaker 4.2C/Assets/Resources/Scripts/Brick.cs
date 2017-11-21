using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {

    public static int breakableCount = 0;

    public int maxHits;
    AudioClip crack;

    int timesHit;

    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {

        breakableCount++;

        crack = Resources.Load("Sounds/crack", typeof(AudioClip)) as AudioClip;
        timesHit = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);

        if (timesHit >= maxHits)
        {
            //TestWin();
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            Destroy(gameObject);
        }
    }
    void TestWin()
    {
        levelManager.LoadNextScene();
    }
}
