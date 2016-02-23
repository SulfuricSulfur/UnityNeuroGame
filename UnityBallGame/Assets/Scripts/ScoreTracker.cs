using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {
    //this script is used for keeping track of the score to pass onto a different scene
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

    public void SetScore(int gameScore)
    {
        score = gameScore;
    }

    public void SetAverage(double avg)
    {
        avgSec = avg;
    }

    public double ShowAverage()
    {
        return avgSec;
    }

    public void SetNumTargets(int numT)
    {
        numTargets = numT;
    }
    public int ShowTargetNum()
    {
        return numTargets;
    }


}
