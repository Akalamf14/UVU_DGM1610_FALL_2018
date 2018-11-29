using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public Transform FirePoint;
	public GameObject Projectiles;
	public int PointsToSubtract;
	


	// Use this for initialization
	void Start () {
		Projectiles = Resources.Load("prefab/Projectiles") as GameObject;	
	}
	
	// Update is called once per frame
	void Update () {

		
		if(Input.GetKeyDown(KeyCode.RightControl) && AmmoManager.Ammo > 0){
			AmmoManager.SubtractPoints(PointsToSubtract);
			Instantiate(Projectiles, FirePoint.position, FirePoint.rotation);
		}

	
			
	}

}
