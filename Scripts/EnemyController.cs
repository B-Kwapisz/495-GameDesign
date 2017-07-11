/*
 * EnemyController.cs
 * 
 * Controls the creation and actions of the enemy units in the game. 
 * Enemys are spawned at random along the platform at the position of the Spawner object. 
 * This script is attached to the Enemy Prefab. On start, a color is assigned at random.
 * Enemies can only be destroyed by bullets of the same color. 
 * The script also controls the movement of the enemy, moving them toward the player at
 * a set speed. If the ship collides with or gets past the player, a life is removed.
 * 
 */

using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
	public Material[] materials;
	Renderer rend;
	public float speed = 3;
	// Use this for initialization
	void Start()
	{
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		transform.Rotate(-30, 0, 0); //rotation due to spawn issues
		int i = Random.Range(0, 6);

		switch (i)
		{
			case 0:
				gameObject.tag = "Red";
				break;
			case 1:
				gameObject.tag = "Blue";
				break;
			case 2:
				gameObject.tag = "Green";
				break;
			case 3:
				gameObject.tag = "Yellow";
				break;
			case 4:
				gameObject.tag = "Magenta";
				break;
			case 5:
				gameObject.tag = "Cyan";
				break;
		}
		rend.sharedMaterial = materials[i];
	}

	// Update is called once per frame
	void Update()
	{
		//constant morion toward player
		Vector3 moveDir = Vector3.zero;
		moveDir.z = -1;

		// move this object at frame rate independent speed:
		transform.position += moveDir * speed * Time.deltaTime;
		//destroy if the enemy makes it past players and apply penalty
		if (transform.position.y < -1)
		{
			Destroy(this.gameObject, 0);
			PlayerPrefs.SetInt("lives", (PlayerPrefs.GetInt("lives") - 1));
		}
	}
	//On Collision, kill on color match or remove life and destroy for player collision
	void OnCollisionEnter(Collision col)
	{
		//if the bullet and the enemy have the same tag destroy enemy and bullet
		if (gameObject.tag == col.gameObject.tag)
		{
			Destroy(this.gameObject, 0);// delete the enemy
			Destroy(col.gameObject, 0); //delete the bullet
			PlayerPrefs.SetInt("score", (PlayerPrefs.GetInt("score") + 1));
		}
		//if enemy collides with the player, apply penalty
		if (col.gameObject.tag == "Player1" || col.gameObject.tag == "Player2")
		{
			Destroy(this.gameObject, 0);
			PlayerPrefs.SetInt("lives", (PlayerPrefs.GetInt("lives") - 1));
		}

	}
}
