using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {
    //the script controller for the main menu
	// Use this for initialization
	void Start () {
	
	}
	
    //used for linking button to the instruction scene
    public void GoToInstructions()
    {
        Application.LoadLevel("Instructions");//loading up the instruction scene
    }

    //used for linking start button to the select trial screen
    public void StartGame()
    {
        Application.LoadLevel("SelectTrial");//going to the trial screen
    }
}
