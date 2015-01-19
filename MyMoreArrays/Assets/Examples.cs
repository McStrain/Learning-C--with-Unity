using UnityEngine;
using System.Collections;

public class Examples : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	void Update()
	{
/*		GameObject go = GameObject.Find("Cube");
		Vector3 CubePosition = go.transform.position;
		Vector3 Up = new Vector3(0, 10, 0);
		Debug.DrawRay (CubePosition, Up);
*/
		GameObject[] gos = GameObject.FindGameObjectsWithTag("Monster");
		ArrayList distances = new ArrayList();
		foreach (GameObject g in gos) 
		{
			Vector3 vec = g.transform.position - transform.position;
			float distance = vec.magnitude;
			//print (distance);
			distances.Add (distance);
		}
		//print (distances.Count);

		float closestValue = (float)distances [0];
		GameObject closestObject = gos[0];
		for (int i = 0; i < gos.Length; i++)
		{
			float d = (float)distances [i];
			if (d < closestValue)
			{
				closestObject = gos[i];
				closestValue = (float)distances[i];
				print (closestValue);
			}
		}

		Vector3 up = new Vector3(0,1,0);
		Vector3 start = closestObject.transform.position;
		Debug.DrawRay(start,up);
	}
	

}
