using UnityEngine;
using System.Collections;

public class Abstraction : MonoBehaviour {





/*
	abstract class BaseClass
	{
		public int counter;
		public abstract void ImportantFunction();
	}
	abstract class SecondaryClass : BaseClass
	{
		public int Limit;
		public abstract bool AtLimit();
		public abstract void SetLimit();
	}
	sealed class ChildClass : SecondaryClass
	{
		public override void ImportantFunction()
		{
			counter++;
			print (counter);
		}
		public override bool AtLimit()
		{
			return counter >= Limit;
		}
		public override void SetLimit()
		{
			Limit = 1;
		}
	}
*/


/*
	abstract class BaseClass
	{
		public int Counter;
		public abstract void ImportantFunction();
	}
	sealed class ChildClass : BaseClass
	{
		public override void ImportantFunction()
		{
			Counter++;
			print (Counter);
		}
	}
	class SiblingClass : BaseClass
	{
		public override void ImportantFunction()
		{
			Counter--;
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
		SiblingClass s = new SiblingClass();
		s.ImportantFunction();
		s.ImportantFunction();
		s.ImportantFunction();
		s.ImportantFunction();

	}
*/
	
	// Update is called once per frame
	void Update () {
		
	}
}
