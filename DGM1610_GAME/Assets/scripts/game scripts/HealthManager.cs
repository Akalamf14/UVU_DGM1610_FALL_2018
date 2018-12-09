using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public static int Health;

	Text HealthText;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 3;

		
	}
	
	// Update is called once per frame
	void Update () {
		if(Health < 0)
			Health = 0;
		
		HealthText.text = "Health " + Health;
		
	}
	public static void AddPoints (int PointsToAdd){
		Health += PointsToAdd;
	}

	public static void SubtractPoints (int PointsToSubtract){
		Health -= PointsToSubtract;
	}

	
}
