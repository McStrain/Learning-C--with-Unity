using UnityEngine;
using System.Collections;
using Zombie;

public class Player : MonoBehaviour {
	public Monster monster;
	public int attackPower;
	void AttackMonster()
	{
		if (monster != null)
		{
			MonsterInfo mi = monster.MonsterInfo;
			Debug.Log (mi.armor);
			if (attackPower >= mi.armor && mi.health > 0)
			{
				monster.TakeDamage(attackPower - mi.armor);
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
