using UnityEngine;
using System.Collections;

public class MyUseStruct : MonoBehaviour 
{
	BoxParameters ThatBox;
	// uses globally accessible BoxParameters struct!

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		ThatBox = GameObject.Find ("Cube").GetComponent<MyStruct>().myParameters;
		gameObject.transform.position = new Vector3(0, ThatBox.height * 0.5f, -10);
	}
}
