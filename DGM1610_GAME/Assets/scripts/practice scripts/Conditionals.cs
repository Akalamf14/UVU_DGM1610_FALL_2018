using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
	
	public bool Weather;



	// Use this for initialization
	void Start () {
		
		if(Weather == "raining")
			print("Weather is" + Weather);
		else if( Weather == "snowing")
			print("Weather is" + Weather);
		else if(Weather == "Sunny")
			print("Weather is" + Weather);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
