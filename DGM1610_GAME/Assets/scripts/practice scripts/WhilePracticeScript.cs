using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhilePracticeScript : MonoBehaviour {

	public int dogs = 50;
	public int cats = 10;
	public int hamsters = 1;

	// Use this for initialization
	void Start () {

		while(dogs < 100){
			print(dogs + "barking");
			dogs --;
		}

		while(cats > 0){
			print(cats + "cats");
			cats ++;
		}

		while(hamsters < 5){
			print(hamsters + "hamsters");
			hamsters --;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
