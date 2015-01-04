using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {
	public int i = 10;

	// Use this for initialization
	void Start () {
		switch (i) 
		{
		case 0:
			Debug.Log("i is zero");
			break;
			
		case 1:
			Debug.Log("i is one");
			break;
			
		case 2:
			Debug.Log("i is two");
			break;
		default:
			Debug.Log("Every other number");
			break;
		}
}
	
	// Update is called once per frame
	void Update () {
	
	}
}
