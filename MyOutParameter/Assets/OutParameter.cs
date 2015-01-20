using UnityEngine;
using System.Collections;

public class OutParameter : MonoBehaviour {
	public GameObject[] GameObjectArray;
	// Use this for initialization
	void Start () 
	{
		ArrayList aList = new ArrayList();
		GameObject[] gameObjects = (GameObject[])GameObject.FindObjectsOfType(typeof(GameObject));
		foreach (GameObject go in gameObjects)
		{
			if(go.name == "Sphere")
			{
				aList.Add (go);
			}
		}
		GameObjectArray = aList.ToArray (typeof(GameObject)) as GameObject[];

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
