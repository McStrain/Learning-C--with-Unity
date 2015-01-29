using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	class GetSet
	{
		private int myInt;
		public int MyInt {get{return myInt;} set{myInt = value;}}
	}
	
	void Start()
	{
		GetSet gs = new GetSet();
		gs.MyInt = 10;
		print (gs.MyInt);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
