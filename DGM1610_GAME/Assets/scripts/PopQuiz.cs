using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopQuiz : MonoBehaviour {

	public int x;
	public int y;
	private int Total;

	void Start(){
		PopQuizAdd();
	}

	public void PopQuizAdd(){

		Add(x, y);
	}

	public void Add(int x, int y){

		Total = x + y;

		print(Total);
	}


	
	
}
