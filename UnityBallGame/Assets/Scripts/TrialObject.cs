using UnityEngine;
using System.Collections;

public class TrialObject : MonoBehaviour {

    //this will be the object that sends data about which trial the user selects over to the game scene.
    // Use this for initialization
    public int numTrials;//the number of trials
    TrialSelect trialS;
    GameObject screenObj;//refrence to the canvas object
	void Start () {
        screenObj = GameObject.Find("Canvas");//getting refrence to canvas gameobject
        trialS = screenObj.GetComponent<TrialSelect>();
	}
	
	// Update is called once per frame
	void Update () {
    }

    public int GameTrials()
    {
        
        return numTrials;
    }

    //keeping it alive so can pass info onto next scene.
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void GetTrials(int numT)//gets the number of trials from trialSelect
    {
        numTrials = numT;
    }
}
