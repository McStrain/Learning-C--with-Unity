using UnityEngine;
using System.Collections;

public class MyExample2 : MonoBehaviour {
	TestClass myTestClass = new TestClass();
	// Use this for initialization
	void Start () 
	{
		myTestClass.Name = "John";		
		print (myTestClass.Name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public class TestClass
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
	}
}
