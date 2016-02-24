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
        //loading in the scorehandle from the game scene to access the final score, average score, and the amount of targets there were
        scoreSet = GameObject.Find("ScoreHandle");
        finalScore = scoreSet.GetComponent<ScoreTracker>().ShowingScore();//displaying score
        average = scoreSet.GetComponent<ScoreTracker>().ShowAverage();//Showing the average
        targets=scoreSet.GetComponent<ScoreTracker>().ShowTargetNum();//showing how many targets there were

        //getting the canvas to change the text
        hub = GameObject.Find("Canvas");
        scoring = hub.GetComponent<Transform>().GetChild(0);
        //scoreText = GetComponent<Text>();
        stats = hub.GetComponent<Transform>().GetChild(1);//the stats text

        //feedback for the user
        scoreText = scoring.GetComponent<Text>();
        scoreText.text = "Good work! Your final score is: " + finalScore;

        statText = stats.GetComponent<Text>();
        statText.text = "Out of " + targets + " target(s), your average score from reacting to the target(s) was " + average + " points!";

    }
	
	
}
