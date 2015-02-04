using UnityEngine;
using System.Collections;

public class MyTreadmillManager : MonoBehaviour {
	class Obstacle
	{
		GameObject obstacle;
		//constructor
		public Obstacle()
		{
			obstacle = GameObject.CreatePrimitive (PrimitiveType.Cube);
		}
	}
	private Obstacle[] obstacles;
	public int ObstacleCount = 10;

	// Use this for initialization
	void Start () 
	{
		obstacles = new Obstacle[ObstacleCount];
		//creates a new array of the size requested
		for (int i = 0; i < ObstacleCount; i++)
		{
			obstacles [i] = new Obstacle();
			//fills in the array with new obstacles
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
