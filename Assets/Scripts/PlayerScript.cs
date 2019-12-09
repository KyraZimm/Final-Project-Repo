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
	public static float MapBoundRight;
	public static float MapBoundLeft;
	
	//interaction
	public bool interacting;
	private static bool canAnimate;
	

	void Start () {
		
		//set idle values
		PlayerSpeed = 10;
		interacting = false;

	}
	

	void Update () {
		
		CheckSpeed();
		
		//check for walk animation
		if (interacting)
		{
			canAnimate = false;
		}
		else
		{
			canAnimate = true;
		}
		
		Debug.Log(PlayerPrefs.GetInt("Scene"));

	}

	void CheckSpeed()
	{
		
		//check for left/right key input
		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (interacting == false)
			{
				//set direction
				Direction = Vector2.right;

				if (canAnimate)
				{
					//animation
					sprite.flipX = false;
					anim.SetBool("IsWalking", true);
				}
			}
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (interacting == false)
			{
				//set direction
				Direction = Vector2.left;

				if (canAnimate)
				{
					//animation
					sprite.flipX = true;
					anim.SetBool("IsWalking", true);
				}
			}
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

		if (interacting)
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
