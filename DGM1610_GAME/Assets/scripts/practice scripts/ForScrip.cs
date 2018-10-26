using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPracticeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int q = 5; q >25; q --){
			print("number" + q);

		}

		for(int n = 1; n <= 10; n ++){
			print("My favorite number is" + n);
		}

		for(int kiwi = 0; kiwi >= 30; kiwi --){
			print("this is number" + kiwi);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
