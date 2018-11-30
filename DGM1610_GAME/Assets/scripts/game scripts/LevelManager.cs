using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

	public GameObject Player2;

	public int PointsToSubtract;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	// Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float StoreGravity;

	//use this for initialization
	void start(){
		// Player = FindObjectOfType<Rigidbody2D> ();
		//Player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");

	}

	public IEnumerator RespawnPlayerCo(){
		//generate death particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//player .enabled = false
		Player2.SetActive(false);
		Player.GetComponent<Renderer>().enabled = false;
		// gravity Reset
		StoreGravity = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale =0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		// point penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		// Debug message
		Debug.Log("Player Respawn");
		// Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		// Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = StoreGravity;
		// match Players transform position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//show player
		Player2.SetActive(true);
		Player.GetComponent<Renderer> ().enabled = true;
		// Spawn particle
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);

	}

	
}
