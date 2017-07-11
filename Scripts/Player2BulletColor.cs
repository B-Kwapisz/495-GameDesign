using UnityEngine;
using System.Collections;

public class Player2BulletColor : MonoBehaviour {

	public Material[] materials;
	Renderer rend;
	// Use this for initialization
	void Start () {

		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = materials [0];

		switch (Player2Controller.instance.colorIndex)
		{
		case 0:
			rend.sharedMaterial = materials [0];
			gameObject.tag = "Red";//assign "Red" tag to bullet
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
			gameObject.tag = "Cyan";//assign "Cyan" tag to bullet
			break;
		}
	}
		
}
