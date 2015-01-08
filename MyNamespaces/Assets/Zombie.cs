namespace Zombie
{
	using UnityEngine;
	using System.Collections;
	public class MonsterInfo 
	{
		public int health;
		public int armor;
		public int attack;
		public MonsterInfo()
		{
			health = 10;
			armor = 1;
			attack = 3;
		}
	}
}