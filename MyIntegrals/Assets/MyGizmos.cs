﻿using UnityEngine;
using System.Collections;

public class MyGizmos : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnDrawGizmos()
	{
		Ray r = new Ray();
		r.origin = new Vector3(0,0,0);
		r.direction = new Vector3(0,1,0);
		Gizmos.DrawRay(r);

	}
}
