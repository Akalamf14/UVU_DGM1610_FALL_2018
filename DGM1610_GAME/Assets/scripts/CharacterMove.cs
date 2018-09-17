using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables 
	public int MoveSpeed;
	public float JumpHeight = 15;

	// Player grounded variables
	public Transform Groundcheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;


	// use his for initialization
	void Start () {
		print("hello world");
	}

	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(Groundcheck.position, GroundCheckRadius, WhatIsGround);
	}

	
	// Update is called once per frame
	void Update () {

		// This code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& grounded){
			Jump();
		}

		//this code makes the character move from side to side with the AD keys
		if(Input.GetKey (KeyCode.D)){
			GetComponent<RigidBody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		if(Input.GetKeyDown(KeyCode.A)){
			GetComponent<RigidBody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

	}

	public void Jump(){
		GetComponent<RigidBody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}

