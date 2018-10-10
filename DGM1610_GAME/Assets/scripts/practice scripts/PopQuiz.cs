using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopQuiz : MonoBehaviour {

	public int x;
	public int y;
	public int n;
	private int Total;
	private int Total2;
	private int Total3;

	void Start(){
		PopQuizAdd();

	}

	
	public void PopQuizAdd(){

		Add(x, y, n);
	}
	

	public void PopQuizAdd2(){

		Add(x, y, n);
	}

	public void Add(int x, int y, int n){

		Total = x + y + n;

		print(Total);

		Total2 = x + y - n;

		print(Total2);

		Total3 = x * y + n;

		print(Total3);
		
		Total2 = x + y - n;

		print(Total2);
	}


	
	
}
