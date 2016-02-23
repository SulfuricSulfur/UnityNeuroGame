using UnityEngine;
using System.Collections;

public class TrialSelect : MonoBehaviour {
    //this script is for the user selecting however many trials they want to play
    // Use this for initialization
    public int trials;//the number of trials that there will be
                      //setting up properties for the trial
                      //TrialObject to;

    GameObject trialSetter;
    TrialObject trialObj;


        //setting up way to pass the number of trials through scenes

	void Start () {
        //to = this.GetComponent<TrialObject>();
        trialSetter = GameObject.Find("TrialSetter");
        trialObj = trialSetter.GetComponent<TrialObject>();
    }
	
    //the number of trials there will be depends on the button the user presses
    public void TwoTrials()
    {
        //setting the trials equal to the number on the button
        trials = 2;
        trialObj.GetTrials(trials);
        Application.LoadLevel("Game");//loading the game level
    
    }
    public void ThreeTrials()
    {
        //setting the trials equal to the number on the button
        trials = 3;
        trialObj.GetTrials(trials);
        Application.LoadLevel("Game");//loading the game level
    }
    public void FourTrials()
    {
        //setting the trials equal to the number on the button
        trials = 4;
        trialObj.GetTrials(trials);
        Application.LoadLevel("Game");//loading the game level
    }
    public void FiveTrials()
    {
        //setting the trials equal to the number on the button
        trials = 5;
        trialObj.GetTrials(trials);
        Application.LoadLevel("Game");//loading the game level
    }

    public int SendTrial()
    {
        return trials;
    }


}
