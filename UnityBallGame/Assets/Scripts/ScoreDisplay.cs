using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    //this is for accessing the score from the other scene to display the final score

    private int score;//the score
    GameObject scoreHandler;//the object that handles the score in the other scene

    private GameObject hub;//the canvas
    Transform showScore;//the textbox
    Text displayFScore;//displaying the final score

	// Use this for initialization
	void Start () {
        scoreHandler = GameObject.Find("ScoreHandle");
        score = scoreHandler.GetComponent<ScoreTracker>().ShowingScore();

        //setting up the canvas to display text
        hub = GameObject.Find("Canvas");
        showScore = hub.GetComponent<Transform>().GetChild(0);
        displayFScore = showScore.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        displayFScore.text = "Good job! Your score was: " + score;
	}
}
