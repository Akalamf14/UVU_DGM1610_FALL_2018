using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

	public float Speed;
	public RigidBody2D PC;
	public GameObject EnemyDeath;

	public GameObject ProjectilesParticle;

	public int PointForKill;

	// Use this for initialization
	void Start () {
		if(PC.transform.LocalScale.x < 0)
			Speed = -Speed
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<RigidBody2D>().velocity = new Vector2(Speed, GetComponent<RigidBody2D>().velocity.y);
	}

	void OnTriggerEnter2D(collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy(other.GameObject);
			ScoreManager.AddPoints(PointsForKill);
		}

		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy(GameObject);
	}
}
