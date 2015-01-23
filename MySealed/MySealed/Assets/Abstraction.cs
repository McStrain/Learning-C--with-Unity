using UnityEngine;
using System.Collections;

public class Abstraction : MonoBehaviour {
	abstract class BaseClass
	{
		public int Counter;
		public abstract void ImportantFunction();
	}
	class ChildClass : BaseClass
	{
		public override void ImportantFunction()
		{
			Counter++;
			print (Counter);
		}
	}
	// Use this for initialization
	void Start () 
	{
		ChildClass c = new ChildClass();
		c.ImportantFunction();
		c.ImportantFunction();
		c.ImportantFunction();
		c.ImportantFunction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
