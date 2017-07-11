/*
* InGameUI is a controller script that manages the ingame HUD
* and is responsible for ending the game in the event that the 
* player as expended their alloted lives.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour {

	public Text scoreValue; //score
	public Text livesValue; //lives

	// Called at start of game
	void Start() {
		PlayerPrefs.SetInt ("score", 0); // reset score to 0
		PlayerPrefs.Save(); // save the reset
		PlayerPrefs.SetInt("lives", 10); // reset lives to 10
		PlayerPrefs.Save(); // save the reset
	}

	// Update is called once per frame
	void Update () {
		scoreValue.text = PlayerPrefs.GetInt ("score").ToString(); // display score 
		livesValue.text = PlayerPrefs.GetInt ("lives").ToString (); // display lives

		if (PlayerPrefs.GetInt ("lives") == 0) //if lives fall to 0...
		{
			Application.LoadLevel ("GameOver"); //end game
		}
	}
}
