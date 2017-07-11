using UnityEngine;
using System.Collections;

public class Player1Barrel : MonoBehaviour
{
	//spawns rigid projectile 
	public Rigidbody projectile;
	//speed of projectile
	public int speed = 40;

	void Update()
	{
		if (Input.GetButtonDown("Fire1")) //when player hits up or W...
		{
			//spawn bullet object from prefabs
			Rigidbody clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			//shoot bullet object forward
			clone.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
			//destroy bullet object after 3 seconds
			Destroy(clone.gameObject, 3);
		}


	}

}

