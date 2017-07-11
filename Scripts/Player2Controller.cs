using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player2Controller : MonoBehaviour {
	public float speed = .25f; // speed in meters per second
	private Rigidbody rb;
	private Vector3 startingPosition;
	public int colorIndex = 0;
	public Renderer rend;
	public static Player2Controller instance;

	public Material[] materials;
	//materials array contains Red at index 0, Blue:1, Green:2, Yellow:3, Magenta:4, Cyan:5

	void Start ()
	{
		instance = this;
		rb = GetComponent<Rigidbody>();
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = materials [0]; //players are Red by default
	}

	void Awake() 
	{
		startingPosition = this.transform.position;
	}





	void Update()
	{

		MovePlayer ();

		ChangePlayerColor ();

	}

	void MovePlayer()
	{
		
			Vector3 moveDir = Vector3.zero;
			moveDir.x = Input.GetAxis ("Horizontal2"); // get result of AD keys in X
			// move this object at frame rate independent speed:
			transform.position += moveDir * speed * Time.deltaTime;

	}

	void ChangePlayerColor()
	{
		if(Input.GetButtonDown("Vertical2"))
		{
			if (colorIndex >= 2) 
			{   //player can only change between Red, Blue, and Green
				//if the player is Green or any color "higher" than Green, the color should change back to Red	
				//Yellow, Magenta, and Cyan can only be accessed by touching other player
				rend.sharedMaterial = materials [0];
				colorIndex = 0;
			} 
			else 
			{
				rend.sharedMaterial = materials [colorIndex + 1];
				colorIndex++;
			}
		}
	}
}
