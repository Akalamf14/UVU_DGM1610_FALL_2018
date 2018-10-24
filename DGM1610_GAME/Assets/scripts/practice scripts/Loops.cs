using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int num = 40;


	// Use this for initialization
	void Start () {
		// for(int I = 0; I <= 100; I ++){

		// 	print(I + "Ants Marching");
	
		while(num > 0){
			print("countdown" + num);
			num --;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
