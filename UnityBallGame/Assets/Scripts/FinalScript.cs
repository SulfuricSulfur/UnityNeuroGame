using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FinalScript : MonoBehaviour {

    // Use this for initialization
    //this is for displaying the final score
    private int finalScore;
    private double average;
    private int targets;
    GameObject scoreSet;
    private GameObject hub;
    Transform scoring;
    Text scoreText;
    Transform stats;
    Text statText;
    
    //displaying score on hub canvas

	void Start () {
        scoreSet = GameObject.Find("ScoreHandle");
        finalScore = scoreSet.GetComponent<ScoreTracker>().ShowingScore();//displaying score
        average = scoreSet.GetComponent<ScoreTracker>().ShowAverage();//Showing the average
        targets=scoreSet.GetComponent<ScoreTracker>().ShowTargetNum();//showing how many targets there were

        hub = GameObject.Find("Canvas");
        scoring = hub.GetComponent<Transform>().GetChild(0);
        //scoreText = GetComponent<Text>();
        stats = hub.GetComponent<Transform>().GetChild(1);//the stats text


        scoreText = scoring.GetComponent<Text>();
        scoreText.text = "Good work! Your final score is: " + finalScore;

        statText = stats.GetComponent<Text>();
        statText.text = "Out of " + targets + " target(s), your average score from reacting to the target was " + average + " points!";

    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
