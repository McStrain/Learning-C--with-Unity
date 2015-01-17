using UnityEngine;
using System.Collections;

public class HumanState : ZombieState {

	override public void LookAround()
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
				if (z is ZombieState)
				{
					closestDistance = distanceToGo;
					closestGameObject = go;
				}
			}
			if (distanceToGo > furthestDistance)
			{
				if (z is HumanState)
				{
					furthestDistance = distanceToGo;
					furthestGameObject = go;
				}
			}
		}
	}
}
