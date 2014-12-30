using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
	string Name;
	int hitPoints;
	int brainsEaten;
	// Use this for initialization
	void Start () {

		// Simple way to assign parameters to a Zombie
		Zombie rob = new Zombie();
		rob.Name = "Zombie";
		rob.hitPoints = 10;
		rob.brainsEaten = 0;

		// Alternate way
		Zombie bob = new Zombie() {
			Name = "Zombie",
			brainsEaten = 0,
			hitPoints = 10
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
