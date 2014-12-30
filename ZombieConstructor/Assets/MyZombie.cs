using UnityEngine;
using System.Collections;

public class MyZombie : MonoBehaviour {
	public string Name;
	public int brainsEaten;
	public int hitPoints;
	public MyZombie()
	{
		Name = "MyZombie";
		brainsEaten = 0;
		hitPoints = 10;
	}

	MyZombie rob = new MyZombie();



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
