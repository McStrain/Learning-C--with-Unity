using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	class GetSet
	{
		public int myInt {get; set;}
	}
	
	void Start()
	{
		GetSet gs = new GetSet();
		gs.myInt = 10;
		print (gs.myInt);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
