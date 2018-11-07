using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenMoreArraysWithForLoop : MonoBehaviour {


	public int[] num;
	public string[] name;

	// Use this for initialization
	void Start () {

		num = new int[4];

		num[0] = 1;
		num[1] = 2;
		num[2] = 3;
		num[3] = 4;
		num[4] = 5;

		for(int num = 0; num < 4; num ++){
			print(num);
		}


		name = new string[5];

		name[0] = "Kathy";
		name[1] = "lindsey";
		name[2] = "Marie";
		name[3] = "Camila";
		name[4] = "Rosa";
		name[5] = "Emma";

		foreach(string person in name){
			print("my name is" + person);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
