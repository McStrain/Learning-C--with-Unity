﻿using UnityEngine;
using System.Collections;

// Moving the parameters below out to a seperate Globals.cs file...
/*
// living out in the open
public struct BoxParameters 
{
	public float width;
	public float height;
	public float depth;
	public Color color;
}
*/
public class MyStruct : MonoBehaviour {

	// put the new Struct to use and name it myParameters
	public BoxParameters myParameters;


	// Use this for initialization
	void Start () {
		myParameters.width = 2;
		myParameters.height = 3;
		myParameters.depth = 4;
		myParameters.color = new Color(1,0,0,1);
	}

	void UpdateCube (BoxParameters box) 
	{
		Vector3 size = new Vector3(box.width, box.height, box.depth);
		gameObject.transform.localScale = size;
		gameObject.renderer.material.color = box.color;
	}

	// Update is called once per frame
	void Update () {
		float h = (100 * Mathf.Sin (Time.fixedTime) / 10) ;
		myParameters.height = h;
		UpdateCube (myParameters);
	}
}
