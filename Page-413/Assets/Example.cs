using UnityEngine;
using System.Collections;
	

public class Example : MonoBehaviour {
	void someFunction(out int x, out int y)
	{
		x = 7;
		y = 13;
	}
	void Start()
	{
		int firstInt = 0;
		int secondInt = 0;
		someFunction(out firstInt, out secondInt);
		print (firstInt + " " + secondInt);
	}


	
	// Update is called once per frame
	void Update () {
	}
}
