using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
    //this is the script for returning the player to the main menu.
    //this will be used in multiple scenes, so it is not for a specific scene.
    // Use this for initialization

	void Start () {
	
	}

	public void ReturnToMenu()
    {
        Application.LoadLevel("Main");
    }
}
