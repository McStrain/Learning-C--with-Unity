using UnityEngine;
using System.Collections;

public class Child : Parent {

	// Use this for initialization
	void Start () 
	{
		base.FunctionA ();
		ParentFunction();

	}

	public override void FunctionA()
	{
		print ("I'm a new version of function A");
	}



}
