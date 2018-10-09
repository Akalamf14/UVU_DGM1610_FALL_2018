using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopQuiz : MonoBehaviour {

	public int x;
	public int y;
	public int n;
	private int Total;
	private int Total2;
<<<<<<< HEAD
	private int Total3;

	void Start(){
		PopQuizAdd();
		
=======

	void Start(){
		PopQuizAdd();
		PopQuizAdd2();
>>>>>>> master
	}

	public void PopQuizAdd(){

		Add(x, y, n);
	}
<<<<<<< HEAD
	

=======
	public void PopQuizAdd2(){

		Add(x, y, n);
	}

>>>>>>> master
	public void Add(int x, int y, int n){

		Total = x + y + n;

		print(Total);
<<<<<<< HEAD

		Total2 = x + y - n;

		print(Total2);

		Total3 = x * y + n;

		print(Total3);

		
		
=======
		
		Total2 = x + y - n;

		print(Total2);
>>>>>>> master
	}


	
	
}
