using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	// Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	//use this for initialization
	void start(){
		Player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");

	}

	//public IEnumerator RespawnPlayerCo(){
		//generate death particle
		//Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
	
}
