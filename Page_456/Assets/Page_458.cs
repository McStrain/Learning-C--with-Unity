using UnityEngine;
using System.Collections;

public class Page_458 : MonoBehaviour {
	class GetSet
	{
		public delegate void MyIntHandler(int i);
		public event MyIntHandler MyIntEvent;
		private int myInt;
		public int MyInt
		{
			get {return myInt;}
			set
			{
				myInt = value;
				//raise an event if there are any assigned functions
				if (MyIntEvent != null)
				{
					MyIntEvent(myInt);
				}
			}
		}
	}




	// Use this for initialization
	void Start () 
	{
		GetSet gs = new GetSet();
		//assign a function to be raised when the falue is changed
		gs.MyIntEvent += IntChanged;
		//set a value, this will raise an event!
		gs.MyInt = 10;
	}

	void IntChanged (int i)
	{
		print ("change! " + i);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
