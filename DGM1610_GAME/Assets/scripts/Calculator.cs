using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	public int x;
	public int y;
	private int total;
	private int toatl2;

	
	
	public void Subtract(int x, int y){

		total = x - y;

		print(total);

	}

	void Start () {
		
		CalculatorSubtract();
	}
	
	public void CalculatorSubtract(){

		Subtract(x, y);
	}
}
