using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		int a = GameObject.CreatePrimitive(PrimitiveType.Capsule).GetInstanceID();
		int b = a;
		print (a);
		print (b);
		print (a == b);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
