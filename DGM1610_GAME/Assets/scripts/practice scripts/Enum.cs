using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour {

	enum Inventory {cheese =1, meat = 10, sword = 1, shield = 2, map = 0, backpack = 3, water = 20};



	// Use this for initialization
	void Start () {
		
		print(Inventory.cheese);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
