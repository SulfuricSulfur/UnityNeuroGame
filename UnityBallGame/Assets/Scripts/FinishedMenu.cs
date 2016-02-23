using UnityEngine;
using System.Collections;

public class FinishedMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //going to the main menu
    public void MainMenu()
    {
        Application.LoadLevel("Main");
    }
}
