using UnityEngine;
using System.Collections;

public class MonsterState2 : MonoBehaviour {
	public enum MonsterState
	{
		standing,
		wandering,
		chasing,
		attacking
	}
	public MonsterState mState;

	// Use this for initialization
	void Start () {
		mState = MonsterState.attacking;
		int number = (int)mState;
		Debug.Log(number);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
