using UnityEngine;
using System.Collections;

public class MyExample2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		print (NumbersAreTheSame(3, 3));
		print (NumbersAreTheSame(4, 3));
	}


	bool NumbersAreTheSame(int a, int b) {
		if (a == b) {
			return true;
		}
		return false;
	}



	// Update is called once per frame
	void Update () {
	
	}
}
