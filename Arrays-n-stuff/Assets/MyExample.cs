using UnityEngine;
using System.Collections;

public class MyExample : MonoBehaviour {
	public int numBoxes = 10;
	public GameObject[] boxes;
	public float spacing;

	// Use this for initialization
	void Start () {
		boxes = new GameObject[numBoxes];
		for (int i = 0; i < numBoxes; i++) {
			GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
			box.AddComponent("Monster");  // Add component here!
			Monster m = box.GetComponent("Monster") as Monster;
			m.ID = i;
			m.spacing = spacing;
			boxes [i] = box;
		}
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		foreach (GameObject  go in boxes) {
//			float wave = Mathf.Sin(Time.fixedTime + i);
//			go.transform.position = new Vector3(i * spacing, wave, 0);
			i++;
			//print (Time.fixedTime);
		}
	}
}
