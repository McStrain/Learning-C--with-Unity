using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Zombie a = new Zombie();
		Zombie b = new Zombie();
		Zombie c = a + b;
		print ("test");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
