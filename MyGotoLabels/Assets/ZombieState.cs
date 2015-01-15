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
	float closestDistance;
	float furthestDistance;
	GameObject closestGameObject;
	GameObject furthestGameObject;
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
		}
			return;
	Wandering:
			stateTimer -= Time.deltaTime;
		if(stateTimer < 0.0f)
		{
			MyState = ZState.idleing;
			stateTimer = 3.0f;
		}
		return;

	}

	void LookAround()
	{
		GameObject[] Zombies = (GameObject[]) GameObject.FindObjectsOfType(typeof(GameObject));
		foreach (GameObject go in Zombies) 
		{
			ZombieState z = go.GetComponent<ZombieState>();
			if(z == null || z == this)
			{
				continue;
			}
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
}
