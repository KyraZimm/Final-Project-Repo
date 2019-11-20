using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	//attached components
	public Rigidbody2D rb;
	public Animator anim;
	public SpriteRenderer sprite;
	
	//movement
	private static float PlayerSpeed;
	private static float JumpForce;
	private static Vector2 Direction;
	private static bool onFloor;
	
	//map attributes
	//set this as a reference later, instead of manual value
	public static float MapBoundRight;
	public static float MapBoundLeft;

	
	void Start () {
		
		//set idle values
		PlayerSpeed = 10;
		JumpForce = 10;
			//note - change these values once placeholders are replaced. Set to reference map sprite.
			MapBoundLeft = -40;
			MapBoundRight = 40;

		onFloor = false;

			//reference components


	}
	

	void Update () {
		
		CheckSpeed();
		
	}

	void CheckSpeed()
	{
		
		//check for left/right key input
		if (Input.GetKey(KeyCode.RightArrow))
		{
			//set direction
			Direction = Vector2.right;
			
			//animation
			sprite.flipX = false;
			anim.SetBool("IsWalking", true);
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			//set direction
			Direction = Vector2.left;
			
			//animation
			sprite.flipX = true;
			anim.SetBool("IsWalking", true);
		}
		else
		{
			//idle
			Direction = new Vector2(0, 0);
			anim.SetBool("IsWalking", false);
		}
		
		//"up" function--when standing next to ladder/stairs, player can go up
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && onFloor)
		{
			Direction += Vector2.up * JumpForce; 
		}
			
		
		//check player boundaries
		if (transform.position.x >= MapBoundRight || transform.position.x <= MapBoundLeft)
		{
			Direction = new Vector2(0, 0);
		}

		var Velocity = Direction * PlayerSpeed;
		rb.velocity = Velocity;

		//transform.Translate(Direction * PlayerSpeed * Time.deltaTime);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Floor")
		{
			onFloor = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.tag == "Floor")
		{
			onFloor = false;
		}
	}
}
