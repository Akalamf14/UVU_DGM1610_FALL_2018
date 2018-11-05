using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string name;


	// Use this for initialization
	void Start () {
		if(num == 10){
			print("hooray you picked ten");
		}
		else{
			print("Boo! you didn't pick ten");
		}
	
		switch(num){
				
			case 1:
				print("you picked" + num);
			break; 

			case 3:
				print("you picked" + num);
			break;

			case 5:
				print("you picked" + num);
			break;

			default:
				print("i dont understand" + num);
			break;

			}

		switch(name){
			case "Jason":
				print("Welcome to camp crystal lake" + name + "love another");
			break;

			case "Michael":
				print("Welcome to New York" + name);
			break;

			case "Freddie":
				print("Welcome to elm street" + name);
			break;

			case "leatherface":
				print("the stars are big at night...deep in the hear of Texas");
			break;

			default:
				print("I don't know" + name);
			break;

			}
	}
	

}
