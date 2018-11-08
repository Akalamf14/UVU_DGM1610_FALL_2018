using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysQuiz : MonoBehaviour {

	public string[] pets;


	// Use this for initialization
	void Start () {

		pets = new string[5];

		pets[0] = "Dog";
		pets[1] = "Cat";
		pets[2] = "Bird";
		pets[3] = "Hamster";
		pets[4] = "Goldfish";
		pets[5] = "turtle";
		
		foreach(string animal in pets){
			print("I own a" + animal);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
