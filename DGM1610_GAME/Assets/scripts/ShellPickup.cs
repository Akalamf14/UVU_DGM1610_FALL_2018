using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellPickup : MonoBehaviour {

	public int PointsToAdd;

void OnTrigger2D(Collider2D shells){
	if(shells.GetComponent<Rigidbody2D>() == null)
		return;

	ScoreManager.AddPoints(PointsToAdd);

	Destroy(gameObject);
}
}
