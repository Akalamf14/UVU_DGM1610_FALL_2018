using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreSwitchesPractice : MonoBehaviour {

	public string color;
	public int time = 10;

	// Use this for initialization
	void Start () {

		switch(color){

			case "red":
				print("the object is" + color);
			break;

			case "blue":
				print("the object is" + color);
			break;

			case "green":
				print("the object is" + color);
			break;

			case "yellow":
				print("the object is" + color);
			break;

			case "orange":
				print("the object is" + color);
			break;
		}

		switch(time){

			case 1:
				print( "you have" + time + "seconds left");
			break;

			case 2:
				print( "you have" + time + "seconds left");
			break;

			case 3:
				print("you have" + time + "seconds left");
			break;

			case 4:
				print("you have" + time + "seconds left");
			break;

			case 5:
				print("you have" + time + "seconds left");
			break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
