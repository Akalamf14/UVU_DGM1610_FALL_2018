using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPractice : MonoBehaviour {

		public float[] star;

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
