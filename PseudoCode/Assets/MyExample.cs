using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {
	// Use this for initialization
	void Start () {
		MyMembers m = new MyMembers();
		m.FirstFunction();
	}
	
	// Update is called once per frame
	void Update () {
		bool AKey = Input.GetKey (KeyCode.A);
		Debug.Log (AKey);

	
	}
}
