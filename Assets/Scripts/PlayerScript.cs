using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	//attached components
	public Animator anim;
	public SpriteRenderer sprite;
	
	//movement
	private static float PlayerSpeed;
	private static Vector2 Direction;
	
	//map attributes
	//set this as a reference later, instead of manual value
	public static float MapBoundRight;
	public static float MapBoundLeft;

	private void Awake()
	{
		PlayerPrefs.SetInt("Scene", 0);
	}

	void Start () {
		
		//set idle values
		PlayerSpeed = 10;


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

		//check player boundaries
		if (transform.position.x >= MapBoundRight && Input.GetKey(KeyCode.RightArrow)
		    || transform.position.x <= MapBoundLeft && Input.GetKey(KeyCode.LeftArrow))
		{
			Direction = new Vector2(0, 0);
		}

		transform.Translate(Direction * PlayerSpeed * Time.deltaTime);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Floor")
		{
			MapBoundLeft = -((other.gameObject.transform.localScale.x / 2) - other.gameObject.transform.localPosition.x);
			MapBoundRight = (other.gameObject.transform.localScale.x / 2) + other.gameObject.transform.localPosition.x;
		}
	}
}
