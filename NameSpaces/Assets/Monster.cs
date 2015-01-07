using UnityEngine;
using System.Collections;
using Zombie;

public class Monster : MonoBehaviour {
	MonsterInfo monster = new MonsterInfo();
	// Use this for initialization
	void Start () {
		MonsterInfo m = monster;
		Debug.Log (m.health);
		Debug.Log (m.armor);
		Debug.Log (m.attack);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
