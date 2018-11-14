using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public int PointsToSubtract;


	void OnTriggerEnter2D(Collider2D other){
		if(other.GetComponent<Rigidbody2D>() == null)
			return;

		HealthManager.SubtractPoints(PointsToSubtract);

		Destroy(GameObject);
	}
}
