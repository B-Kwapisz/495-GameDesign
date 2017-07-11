/*
 * EnemySpawn.cs
 * 
 * Controls the generation of the enemy units in the game. Enemys are spawned at random along 
 * the platform at the position of the Spawner object. The enemies initially spawn every 
 * 4 seconds. This is decreased as the level continues until enemies spawn every 2 seconds.
 * 
 */

using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
	public bool spawnerEnabled;
	public float spawnDelay = 4f;
	public Rigidbody enemy;
	// Use this for initialization
	void Start()
	{
		spawnerEnabled = true;

	}

	// Update is called once per frame
	void Update()
	{

		if (spawnerEnabled)
			StartCoroutine(SpawnEnemy());
	}

	IEnumerator SpawnEnemy()
	{
		while (spawnerEnabled)
		{
			spawnerEnabled = false;
			//generate a random value to randomize spawn position
			float r = Random.Range(-3.5f, 3.5f);
			Vector3 spawnPosition = Vector3.zero;
			spawnPosition = new Vector3(transform.position.x - r, transform.position.y, transform.position.z);
			//script is attached to EnemySpawner object, spawning enemies randomly along x axis
			Rigidbody clone = Instantiate(enemy, spawnPosition, transform.rotation) as Rigidbody;
			//increase speed everytime an enemy is spawned	
			yield return new WaitForSeconds(spawnDelay);
			spawnerEnabled = true;
			spawnDelay -= .1f;
			if (spawnDelay <= 2)
				spawnDelay = 2;
		}
	}

}
