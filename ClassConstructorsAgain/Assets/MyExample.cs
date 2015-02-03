using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {
	//sub class declaration
	public class MyClass
	{
		//sub-class string called name
		private string name;
		//funciton with same identifier as class name
		public MyClass(string n)
		{
			//assigns the internal name to string n
			name = n;
		}

		public MyClass(int n)
		{
			name = n.ToString ();
		}
	}
	// Use this for initialization
	void Start () 
	{
	//uses the class constructor, names the class bob
		MyClass mc = new MyClass("bob");
		MyClass mc2 = new MyClass(3);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
