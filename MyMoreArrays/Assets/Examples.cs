using UnityEngine;
using System.Collections;

public class Examples : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	void Update()
	{
		GameObject go = GameObject.Find("Cube");
		Vector3 CubePosition = go.transform.position;
		Vector3 Up = new Vector3(0, 10, 0);
		Debug.DrawRay (CubePosition, Up);



	}
	

}
