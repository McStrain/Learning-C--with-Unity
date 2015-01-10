using UnityEngine;
using System.Collections;

public class TypeCasting : MonoBehaviour {
	class Humanoid
	{
		public int hitpoints;
	}
	class Zombie : Humanoid
	{

	}
	class Person : Humanoid
	{
		static public implicit operator Zombie(Person p)
		{
			Zombie z = new Zombie();
			z.hitpoints = p.hitpoints * -1;
			return z;
		}
	}

	// Use this for initialization
	void Start () 
	{
		Person p = new Person();
		Zombie z = (Zombie)p;
		Debug.Log(z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
