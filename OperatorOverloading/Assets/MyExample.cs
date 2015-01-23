using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {

	class Zombie
	{
		public int damage = 10;
		public static bool operator < (Zombie a, Zombie b)
		{
			if (a.damage < b.damage)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator > (Zombie a, Zombie b)
		{
			if (a.damage > b.damage)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	class Supplies
	{
		public int bandages;
		public int ammunition;
		public float weight;
		public Supplies(int size)
		{
			bandages = size;
			ammunition = size * 2;
			weight = bandages * 0.2f + ammunition * 0.7f;
		}
		public static Supplies operator * (Supplies a, int b)
		{
			Supplies s = new Supplies(0);
			int sBandages = a.bandages * b;
			int sAmmunition = a.ammunition * b;
			float sWeight = a.weight * b;
			s.bandages = sBandages;
			s.ammunition = sAmmunition;
			s.weight = sWeight;
			return s;
		}
	}


	// Use this for initialization
	void Start () 
	{
		Zombie a = new Zombie();
		Zombie b = new Zombie();
		a.damage = 9;
		if (a < b);
		{
			print ("a has less damage!");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
