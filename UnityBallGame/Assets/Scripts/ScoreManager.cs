using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    //this is for adding/changing the score depending on the situation
	// Use this for initialization
	void Start () {
	
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
        int initialScore = 400;
        initialScore -= 15;//the longer the user lets the target show, the more their points go down
        return initialScore;
    }

    /// <summary>
    /// This is for if the player presses the spacebar
    /// when it isn't the target. The more the user gets it wrong,
    /// the more the decrease score will increase by.
    /// </summary>
   public int ScoreDecrease(int loseStreak)
    {
        int baseLose = 20 * loseStreak;//the lose streak will increase each time the player presses the space when they shouldn't have
        return baseLose;
    }


    /// <summary>
    /// everytime the user doesn't press the spacebar when it isn't
    /// the target, this will increase their score.
    /// </summary>
    /// <param name="winstreak"></param>
    /// <returns></returns>
    public int IncreaseOverTime(int winstreak)
    {
        return 25 * winstreak;
    }

}
