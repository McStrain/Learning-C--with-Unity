using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	public enum MonsterState {
		standing,
		wandering,
		chasing,
		attacking
	}
	public MonsterState mState;

	// Use this for initialization
	void Start () {
		mState = MonsterState.wandering;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (mState == MonsterState.standing)
			{
				print ("standing monster is standing");
			}
		if (mState == MonsterState.wandering)
			{
				print ("standing monster is wandering");
			}
		if (mState == MonsterState.chasing)
			{
				print ("standing monster is chasing");
			}
		if (mState == MonsterState.attacking)
			{
				print ("standing monster is attacking");
			}
	}
}
