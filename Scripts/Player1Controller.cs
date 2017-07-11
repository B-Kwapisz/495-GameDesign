using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player1Controller : MonoBehaviour {
	public float speed = .25f; // speed in meters per second
	private Rigidbody rb;
	private Vector3 startingPosition;
	public int colorIndex = 0;
	public Renderer rend;
	public static Player1Controller instance;

	public Material[] materials;
	//materials array contains Red at index 0, Blue:1, Green:2, Yellow:3, Magenta:4, Cyan:5

	void Start ()
	{
		instance = this;
		rb = GetComponent<Rigidbody>();
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = materials [0]; //players are red by default
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
			moveDir.x = Input.GetAxis ("Horizontal1"); // get result of AD keys in X
			// move this object at frame rate independent speed:
			transform.position += moveDir * speed * Time.deltaTime;

	}
		
	void ChangePlayerColor()
		{
			if(Input.GetButtonDown("Vertical1"))
			{
			if (colorIndex >= 2) 
			{ //player can only change between Red, Blue, and Green
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
	void OnCollisionStay(Collision col)
	{
		if (col.gameObject.tag == "Player2") 
		{
			//if players touch and combine Red and Green, they both become Yellow
			if (Player2Controller.instance.colorIndex == 0 && colorIndex == 2
				|| Player2Controller.instance.colorIndex == 2 && colorIndex == 0) 
			{
				rend.sharedMaterial = materials [3];
				colorIndex = 3;
				Player2Controller.instance.rend.sharedMaterial = materials [3];
				Player2Controller.instance.colorIndex = 3;
			}
			//if players touch and combine Red and Blue, they both become Magenta
			if (Player2Controller.instance.colorIndex == 0 && colorIndex == 1
				|| Player2Controller.instance.colorIndex == 1 && colorIndex == 0) 
			{
				rend.sharedMaterial = materials [4];
				colorIndex = 4;
				Player2Controller.instance.rend.sharedMaterial = materials [4];
				Player2Controller.instance.colorIndex = 4;
			}
			//if players touch and combine Green and Blue, they both become Cyan
			if (Player2Controller.instance.colorIndex == 2 && colorIndex == 1
				|| Player2Controller.instance.colorIndex == 1 && colorIndex == 2) 
			{
				rend.sharedMaterial = materials [5];
				colorIndex = 5;
				Player2Controller.instance.rend.sharedMaterial = materials [5];
				Player2Controller.instance.colorIndex = 5;
			}
		}

	}
	}
