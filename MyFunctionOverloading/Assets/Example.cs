using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	int RetVal()
	{
		return 1;
	}
	float RetVal()
	{
		return 1.0f;
	}

	// Use this for initialization
	void Start () 
	{
		int a = RetVal ();
		float b = RetVal ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
