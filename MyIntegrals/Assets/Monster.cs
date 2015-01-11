using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
	public GameObject PlayerObject;
	public enum MonsterState
	{
		standing,
		wandering,
		chasing,
		attacking
	}
	public MonsterState mState;

	Vector3 Direction;  // class scoped variable


	// Use this for initialization
	void Start()
	{
		int number = (int)mState;
		Debug.Log(number);
		Vector3 pos = new Vector3();
		pos.x = Random.Range (-10f, 10f);
		pos.z = Random.Range (-10f, 10f);
		transform.position = pos;
		GameObject[] AllGameObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject aGameObject in AllGameObjects)
		{
			Component aComponent = aGameObject.GetComponent(typeof(Player));
			if (aComponent != null) 
			{
				PlayerObject = aGameObject;
			}
		}
	}
	 
	// Update is called once per frame
	void Update()
	{
		Direction = Vector3.Normalize(PlayerObject.transform.position - transform.position);

		switch (mState) 
		{
		case MonsterState.standing:
			print("standing monster is standing."); 
			break;
		case MonsterState.wandering:
			print("wandering monster is wandering."); 
			break;
		case MonsterState.chasing:
			print("chasing monster is chasing."); 
			break;
		case MonsterState.attacking:
			print("attacking monster is attacking."); 
			break;
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.DrawLine(transform.position, transform.position + Direction);

	}
}
