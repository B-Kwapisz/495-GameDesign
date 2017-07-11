/*
* Player1BulletColor
* Manages the color of the bullet to match the tank when it is spawned.
* Tags the bullet object with a color to be used for comparison when a collison occurs.
*/

using UnityEngine;
using System.Collections;

public class Player1BulletColor : MonoBehaviour {

	public Material[] materials;
	Renderer rend;
	// Use this for initialization
	void Start () {
	
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = materials [0];
		//changes bullet color to match the color of the tank when fired
		switch (Player1Controller.instance.colorIndex)
		{
		case 0:
			rend.sharedMaterial = materials [0];
			gameObject.tag = "Red"; //assign "Red" tag to bullet (for comparison to enemy object) 
			break;
		case 1:
			rend.sharedMaterial = materials [1];
			gameObject.tag = "Blue";//assign "Blue" tag to bullet
			break;
		case 2:
			rend.sharedMaterial = materials [2];
			gameObject.tag = "Green";//assign "Green" tag to bullet
			break;
		case 3:
			rend.sharedMaterial = materials [3];
			gameObject.tag = "Yellow";//assign "Yellow" tag to bullet
			break;
		case 4:
			rend.sharedMaterial = materials [4];
			gameObject.tag = "Magenta";//assign "Magenta" tag to bullet
			break;
		case 5:
			rend.sharedMaterial = materials [5];
			gameObject.tag = "Cyan";
			break;
		}
	}
		
		
}

