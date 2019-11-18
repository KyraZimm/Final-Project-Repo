using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	//player attributes
	private static float PlayerSpeed;
	private static Vector2 Direction;
	public static bool moveUp;
	
	//map attributes
	//set this as a reference later, instead of manual value
	public static float MapBoundRight;
	public static float MapBoundLeft;

	
	void Start () {
		
		//set idle values
		PlayerSpeed = 10;
			//note - change these values once placeholders are replaced. Set to reference map sprite.
			MapBoundLeft = -40;
			MapBoundRight = 40;

	}
	

	void Update () {
		
		CheckSpeed();
		
	}

	void CheckSpeed()
	{
		
		//check for left/right key input
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Direction = Vector2.right;
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			Direction = Vector2.left;
		}
		else
		{
			Direction = new Vector2(0, 0);
		}
		
		//"up" function--when standing next to ladder/stairs, player can go up
		if (moveUp)
		{
			Direction = Vector2.up;
		}
		
		//check player boundaries
		if (transform.position.x >= MapBoundRight || transform.position.x <= MapBoundLeft)
		{
			Direction = new Vector2(0, 0);
		}

		transform.Translate(Direction * PlayerSpeed * Time.deltaTime);
		
	}
	

}
