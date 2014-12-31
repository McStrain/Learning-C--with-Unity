using UnityEngine;
using System.Collections;

class MyZombie {
	public string Name;
	public int brainsEaten;
	public int hitPoints;
	GameObject ZombieMesh;
	public MyZombie(string n, int hp)
	{
		Name = n;
		brainsEaten = 0;
		hitPoints = hp;
		ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
		Vector3 pos = new Vector3();
		pos.x = Random.Range(-10, 10);
		pos.y = 0f; // optional
		pos.z = Random.Range (-10, 10);
		ZombieMesh.transform.position = pos;
	}



/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
*/
}
