using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FinalScript : MonoBehaviour {

    // Use this for initialization
    //this is for displaying the final score
    public int finalScore;
    GameObject scoreSet;
    public GameObject hub;
    Transform scoring;
    Text scoreText;
    
    //displaying score on hub canvas

	void Start () {
        scoreSet = GameObject.Find("ScoreHandle");
        finalScore = scoreSet.GetComponent<ObjectSpawn>().ShowingScore();//displaying score
        hub = GameObject.Find("Canvas");
        scoring = hub.GetComponent<Transform>().GetChild(0);
        //scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Text temp = scoring.GetComponent<Text>();
        temp.text = "Good work! Your final score is: " + finalScore;
	}
}
