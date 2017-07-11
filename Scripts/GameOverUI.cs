using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour {

	public Text scoreValue; // score text

	// Use this for initialization
	void Start () {
		scoreValue.text = PlayerPrefs.GetInt ("score").ToString (); // display the score
	}
}
