using UnityEngine;
using System.Collections;
using MyOwnIntType = System.Int16;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		MyOwnIntType c =1;
		print (c.GetType());
	}
	
	// Update is called once per frame
	void Update () {
	}
}
