/*
 * MenuManager
 * Fumctionality for the "PLAY" button; begins the game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	public void Play() {
		Application.LoadLevel ("Level1"); // start level 1
	}
}