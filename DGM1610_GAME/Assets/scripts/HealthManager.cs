using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthMangager : MonoBehaviour {

	public static int Health;

	Text HealthText;


	// Use this for initialization
	void Start () {

		HealthText = GetComponent<Text>();
		
		Health = 5;
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Health < 1){
			print("YOU LOSE");
		}
		
	}

	public static void SubtractPoints (int PointsToSubtract){
		Health -= PointsToSubtract;
	}
}
