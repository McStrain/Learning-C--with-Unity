using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {

	class Zombie
	{
		public int damage = 10;
		public static Zombie operator + (Zombie a, Zombie b)
		{
			Zombie z = new Zombie();
			int powerUp = a.damage + b.damage;
			z.damage = powerUp;
			return z;
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
		public static Supplies operator + (Supplies a, Supplies b)
		{
			Supplies s = new Supplies(0);
			int sBandages = a.bandages + b.bandages;
			int sAmmunition = a.ammunition + b.ammunition;
			float sWeight = a.weight + b.weight;
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
		print (a.damage);
		print (b.damage);
		Zombie c = a + b;
		print (c.damage);

		Supplies supplyA = new Supplies(3);
		Supplies supplyB = new Supplies(9);
		Supplies combinedAB = supplyA + supplyB;
		print (combinedAB.weight);
		Supplies abc = supplyA + supplyB + combinedAB;
		print (abc.weight);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
