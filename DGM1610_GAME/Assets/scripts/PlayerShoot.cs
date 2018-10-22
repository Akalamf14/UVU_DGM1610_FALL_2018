using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public Transform FirePoint;
	public GameObject Projectiles;


	// Use this for initialization
	void Start () {
		Projectiles = GameObject.Find("Projectiles");	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(Projectiles, FirePoint.position, FirePoint.rotation);
	}
}
