using UnityEngine;
using System.Collections;
using MyMyNameSpace;  // adding in a directive to our namespace
using MyAnotherNameSpace;  // adding the seconed namespace with duplicate funtionality
public class MyExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyMyNameSpace.MyClass mc = new MyMyNameSpace.MyClass();
		mc.MyFunction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
