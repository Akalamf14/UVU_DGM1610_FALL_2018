using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

	public float Speed;
	public GameObject PC;
	public GameObject EnemyDeath;

	public GameObject ProjectilesParticle;

	public int PointForKill;

	public int timeOut;

	// Use this for initialization
	void Start () {
		PC = GameObject.Find("PC");

		EnemyDeath = Resources.Load("prefab/death particle") as GameObject;
		ProjectilesParticle = Resources.Load("prefab/death particle") as GameObject;

		if(PC.transform.localScale.x < 0)
			Speed = -Speed;

		Destroy(gameObject,timeOut);
	}


		
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
			ScoreManager.AddPoints(PointForKill);
		}

		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D other){

		Instantiate(ProjectilesParticle, transform.position, transform.rotation);
		Destroy(gameObject);

	}
}
