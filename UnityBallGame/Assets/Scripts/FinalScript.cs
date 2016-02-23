using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FinalScript : MonoBehaviour {

    // Use this for initialization
    //this is for displaying the final score
    private int finalScore;
    GameObject scoreSet;
    private GameObject hub;
    Transform scoring;
    Text scoreText;
    
    //displaying score on hub canvas

	void Start () {
        scoreSet = GameObject.Find("ScoreHandle");
        finalScore = scoreSet.GetComponent<ScoreTracker>().ShowingScore();//displaying score
        hub = GameObject.Find("Canvas");
        scoring = hub.GetComponent<Transform>().GetChild(0);
        //scoreText = GetComponent<Text>();

        Text tempT = scoring.GetComponent<Text>();
        tempT.text = "Good work! Your final score is: " + finalScore;
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
