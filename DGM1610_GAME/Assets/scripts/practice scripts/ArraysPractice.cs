using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPractice : MonoBehaviour {

		public float[] star;
		public string[] university;
		public int[] level;

	// Use this for initialization
	void Start () {

		star = new float[5];

		star[0] = 0;
		star[1] = 50;
		star[2] = 100;
		star[3] = 150;
		star[4] = 200;
		star[5] = 250;

		foreach(float num in star){
			print("there are" + num + "billion stars");
		}


		university = new string[3];

		university[0] = "Utah Valley";
		university[1] = "Utah State";
		university[2] = "U of U";
		university[3] = "BYU";

		foreach(string item in university){
			print("I go to" + item);
		}

		level = new int[2];

		level[0] = 1;
		level[1] = 2;
		level[2] = 3;

		foreach(int element in level){
			print("you are on level" + element);
		}


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
