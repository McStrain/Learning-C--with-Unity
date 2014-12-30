using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		//MyMembers m = new MyMembers();
		//m.FirstFunction();
		pos = transform.position;
	}
	// Update is called once per frame
	void Update () {
		bool AKey = Input.GetKey (KeyCode.A);
		bool SKey = Input.GetKey (KeyCode.S);
		bool WKey = Input.GetKey (KeyCode.W);
		bool DKey = Input.GetKey (KeyCode.D);
		//Debug.Log (AKey);
		if (AKey) {
			pos.x = pos.x - 0.1f;
			print ("A was pressed");
		}
		if (SKey) {
			pos.z = pos.z - 0.1f;
			print ("S was pressed");
		}
		if (WKey) {
			pos.z = pos.z + 0.1f;
			print ("W was pressed");
		}
		if (DKey) {
			pos.x = pos.x + 0.1f;
			print ("D was pressed");
		}
		transform.position = pos;
	
	}
}
