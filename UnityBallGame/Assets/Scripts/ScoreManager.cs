using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    //this is for adding/changing the score depending on the situation
    // Use this for initialization
    private int initialScore;//the base score for the target
	void Start () {
        initialScore = 1200;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>he
    /// This is for increasing the score
    /// when the player hits the space bar for the target.
    /// </summary>
   public int TargetScore()
    {
        initialScore -= 10;//the longer the user lets the target show, the more their points go down
        if (initialScore <= 0)//can't minus points for not hitting it soon enough.
        {
            initialScore = 0;
        }
        return initialScore;
    }

    /// <summary>
    /// This is for if the player presses the spacebar
    /// when it isn't the target. The more the user gets it wrong,
    /// the more the decrease score will increase by.
    /// </summary>
   public int ScoreDecrease(int loseStreak)
    {
        int baseLose = 50 * loseStreak;//the lose streak will increase each time the player presses the space when they shouldn't have
        return baseLose;
    }

    public void ResetTargetScore()
    {
        //returing the base target points
        initialScore = 1200;
    }

    /// <summary>
    /// everytime the user doesn't press the spacebar when it isn't
    /// the target, this will increase their score.
    /// </summary>
    /// <param name="winstreak"></param>
    /// <returns></returns>
    public int IncreaseOverTime(int winstreak)
    {
        return 60 * winstreak;
    }

  

}
