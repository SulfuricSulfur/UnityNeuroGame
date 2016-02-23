using UnityEngine;
using System.Collections;

public class TrialSelect : MonoBehaviour {
    //this script is for the user selecting however many trials they want to play
    // Use this for initialization
    public int trials;//the number of trials that there will be
    //setting up properties for the trial
    //TrialObject to;
    //public bool buttonClicked;//tells if button was clicked and moved onto next scene
        //setting up way to pass the number of trials through scenes

	void Start () {
        //to = this.GetComponent<TrialObject>();
        //buttonClicked = false;
    }
	
    //the number of trials there will be depends on the button the user presses
    public void TwoTrials()
    {
        //setting the trials equal to the number on the button
        trials = 2;
        //buttonClicked = true;
        Application.LoadLevel("Game");//loading the game level
    }
    public void ThreeTrials()
    {
        //setting the trials equal to the number on the button
        trials = 3;
        //uttonClicked = true;
        Application.LoadLevel("Game");//loading the game level
    }
    public void FourTrials()
    {
        //setting the trials equal to the number on the button
        trials = 4;
        //buttonClicked = true;
        Application.LoadLevel("Game");//loading the game level
    }
    public void FiveTrials()
    {
        //setting the trials equal to the number on the button
        trials = 5;
        //buttonClicked = true;
        Application.LoadLevel("Game");//loading the game level
    }

    public int SendTrial()
    {
        return trials;
    }

}
