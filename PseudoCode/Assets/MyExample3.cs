using UnityEngine;
using System.Collections;

public class MyExample3 : MonoBehaviour {
	//public Vector3 pos = Vector3.zero;
	//public float speed;
	float f = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += Movement(speed);

		//pos.z += 0.1f;
		//transform.position = pos;
		f += 0.25f;
		print (f);


		transform.position += Movement ();
	}




	Vector3 Movement() {
		return new Vector3(0.1f, 0.2f, 0.3f);
	}

/*
	// This function is just adding in .2 of input in a direction based on which key is pressed.
	Vector3 Movement(float dist) {
		Vector3 vec = Vector3.zero;
		print ("vec after setting Vector3.zero = " + vec);
		if (Input.GetKey (KeyCode.A)) {
			vec.x -= dist;
		}
		if (Input.GetKey (KeyCode.D)) {
			vec.x += dist;
		}
		if (Input.GetKey (KeyCode.W)) {
			vec.z += dist;
		}
		if (Input.GetKey (KeyCode.S)) {
			vec.z -= dist;
		}
		print ("vec right before the return = " + vec);
		return vec;
	}
*/
}
