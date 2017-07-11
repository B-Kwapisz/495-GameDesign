using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Barrel : MonoBehaviour {

	public Rigidbody projectile;
	public int speed = 40;
	// Use this for initialization
	void Start () {
		

				
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) 
		{
			//spawn bullet object from prefabs
			Rigidbody clone = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));//shoot bullet object forward
			Destroy (clone.gameObject, 2);//destroy bullet object after 2 seconds
		}
		
	}
}
