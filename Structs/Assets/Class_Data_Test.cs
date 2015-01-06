using UnityEngine;
using System.Collections;

public class Class_Data_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] arrayOfInts = new int[100];
		for (int i = 0; i < 10; i++) 
		{
			arrayOfInts[i] = i;
			print (i);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
