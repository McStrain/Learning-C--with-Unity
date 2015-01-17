﻿using UnityEngine;
using System.Collections;

public class ZombieState : MonoBehaviour {
	enum ZState 
	{
		idleing,
		wandering
	}
	ZState MyState;

	float stateTimer;
	public float closestDistance;
	public float furthestDistance;
	public GameObject closestGameObject;
	public GameObject furthestGameObject;
	// Use this for initialization
	void Start () {
		stateTimer = 0.1f;
		MyState = ZState.idleing;
		closestDistance = Mathf.Infinity;
	}
	
	// Update is called once per frame
	void Update () {
		switch (MyState) 
		{
		case ZState.idleing:
			goto Ideling;
		case ZState.wandering:
			goto Wandering;
		default:
			break;
		}
	Ideling:
			stateTimer -= Time.deltaTime;
			if(stateTimer < 0.0f)
		{	
			MyState = ZState.wandering;
			stateTimer = 3.0f;
			closestDistance = Mathf.Infinity;
			furthestDistance = 0f;
			LookAround ();
		}
			return;
	Wandering:
			stateTimer -= Time.deltaTime;
			MoveAround ();
		if(stateTimer < 0.0f)
		{
			MyState = ZState.idleing;
			stateTimer = 3.0f;
		}
		return;

	}

	virtual public void LookAround()
	{
		GameObject[] Zombies = (GameObject[]) GameObject.FindObjectsOfType(typeof(GameObject));
		foreach (GameObject go in Zombies) 
		{
			ZombieState z = go.GetComponent<ZombieState>();
			if(z == null || z == this)
			{
				print ("Entered the null loop.  Continue is next statement.");
				continue;
			}
			print ("This is right after the continue/if loop");
			Vector3 v = go.transform.position - transform.position;
			float distanceToGo = v.magnitude;
			if (distanceToGo < closestDistance)
			{
				closestDistance = distanceToGo;
				closestGameObject = go;
			}
			if (distanceToGo > furthestDistance)
			{
				furthestDistance = distanceToGo;
				furthestGameObject = go;
			}
		}
	}

	void MoveAround()
	{
		Vector3 MoveAway = (transform.position - closestGameObject.transform.position).normalized;
		Vector3 MoveTo = (transform.position - furthestGameObject.transform.position).normalized;
		Vector3 directionToMove = MoveAway - MoveTo;
		transform.forward = directionToMove;
//		gameObject.rigidbody.velocity = directionToMove * Random.Range (10, 30) * 0.1f;
		gameObject.rigidbody.velocity = directionToMove * 0.3f;
		Debug.DrawRay (transform.position, directionToMove, Color.blue);
		Debug.DrawRay(transform.position,closestGameObject.transform.position, Color.red);
		Debug.DrawLine(transform.position, furthestGameObject.transform.position, Color.grey);
	}

}
