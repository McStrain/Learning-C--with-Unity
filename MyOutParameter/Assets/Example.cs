using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	void inAndOut(int inComing, out int outGoing)
	{
		outGoing = inComing * 2;
	}

	void Start()
	{
		int outValue = 0;
		print (outValue);  // Writes 0 to the console
		inAndOut(6, out outValue);
		print (outValue); // Writes 12 to the console
	}





/*
	void goingOut(out int first, out int second, out int third)
	{
		first = 1;
		second = 2;
		third = 3;
	}
	// Use this for initialization
	void Start () 
	{
		int i; // new int
		int j;
		int k;
		goingOut (out i, out j, out k);
		print (i + " " + j + " " + k); 
	}
*/	
	// Update is called once per frame
	void Update () {
	
	}
}
