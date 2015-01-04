using UnityEngine;
using System.Collections;

public class MyExample4 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	Vector3}
	
	// Update is called once per frame
	void Update () 
	{
		int a = 0;
		switch (a) 
		{
		case 0:
		a = 1;
			FirstFunction(a);
			break;
		case 1:
			SecondFunction();
			break;
		}
	}

	void FirstFunction(int i) 
	{
		switch (i) 
		{
		case 0:
			print("first case");
			break;
		case 1:
			print ("I was incremented!");
			break;
		}
	}

	void SecondFunction() 
	{
		print ("second case");
	}
}
