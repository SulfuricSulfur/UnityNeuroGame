using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {
    //this script is used for keeping track of the score to pass onto the final scene
    //this takes in the average reaction score, the final score, and the number of targets.
    //it then passes it on to the final scene where it will be shown on the canvas
    // Use this for initialization

    private int score;
    private double avgSec;//the average seconds
    private int numTargets;//the number of targets there were that round
    //ObjectSpawn spwnObj;//calling refrence to the score
    //GameObject gameScore;//game object of the thing that has the score refrence
    void Start () {
       // gameScore = GameObject.Find("GameObjManager");
        //spwnObj = gameScore.GetComponent<ObjectSpawn>();
        
	}
	
	// Update is called once per frame
	void Update () {
        //score = spwnObj.FinalScore();//passing in the score.
    }

    /// <summary>
    /// showing the score in the final screen
    /// </summary>
    /// <returns></returns>
    public int ShowingScore()
    {
        return score;
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    /// <summary>
    /// taking in the final score
    /// </summary>
    /// <param name="gameScore"></param>
    public void SetScore(int gameScore)
    {
        score = gameScore;
    }

    /// <summary>
    /// taking in and setting the average score from reacting
    /// </summary>
    /// <param name="avg"></param>
    public void SetAverage(double avg)
    {
        avgSec = avg;
    }


    /// <summary>
    /// showing the average score from reacting
    /// </summary>
    /// <returns></returns>
    public double ShowAverage()
    {
        return avgSec;
    }

    /// <summary>
    /// taking in the number of targets there were in that scene
    /// </summary>
    /// <param name="numT"></param>
    public void SetNumTargets(int numT)
    {
        numTargets = numT;
    }

    /// <summary>
    /// transfering the number of targets there were in the game scene
    /// </summary>
    /// <returns></returns>
    public int ShowTargetNum()
    {
        return numTargets;
    }


}
