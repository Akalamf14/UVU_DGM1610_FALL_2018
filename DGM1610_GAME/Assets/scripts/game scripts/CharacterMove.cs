using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables 
	public int MoveSpeed;
	public float JumpHeight = 15;
	private bool Doublejump; 

	// Player grounded variables
	public Transform Groundcheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float movevelocity;

	//public Animator animator;


	// use his for initialization
	void Start () {
		print("hello world");

		//animator.SetBool("IsWalking", false);
		//animator.SetBool("IsJumping", false);

	}

	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(Groundcheck.position, GroundCheckRadius, WhatIsGround);
	}

	
	// Update is called once per frame
	void Update () {

		// This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		//Double Jump Code
		if(Grounded)
		Doublejump = false;

		if(Input.GetKeyDown (KeyCode.Space)&& !Doublejump && !Grounded){
			Jump();
			Doublejump = true;
		}

		//Non-Stick Player
		movevelocity = 0f;

		//Player flip
			if(GetComponent<Rigidbody2D>().velocity.x > 0)
				transform.localScale = new Vector3(8f, 8f, 5f);

			else if (GetComponent<Rigidbody2D>().velocity.x < 0)
				transform.localScale = new Vector3(-8f, 8f, 5f);


		//this code makes the character move from side to side with the AD keys
		if(Input.GetKey (KeyCode.D)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			movevelocity = MoveSpeed;
			//animator.SetBool("IsWalking", true);

		}
		//else if(Input.GetKeyUp(KeyCode.D)){
			//animator.SetBool("IsWalking", false);
		//}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			movevelocity = -MoveSpeed;
			//animator.SetBool("IsWalking", true);
		}
		//else if(Input.GetKeyUp(KeyCode.A)){
			//animator.SetBool("IsWalking", false);

		//}

		GetComponent<Rigidbody2D>().velocity = new Vector2(movevelocity, GetComponent<Rigidbody2D>().velocity.y);

	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		//animator.SetTrigger("IsJumping");
	}

}

