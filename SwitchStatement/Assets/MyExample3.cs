using UnityEngine;
using System.Collections;

public class MyExample3 : MonoBehaviour {
	public enum MyCases {
		first,
		second,
		third,
		forth,
		fifth,
		sixth,
		seventh
	}
	public MyCases cases;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch(cases) {
		case MyCases.first:
			print("first case");
			break;
		case MyCases.second:
			print("second case");
			break;
		case MyCases.third:
			print("third case");
			break;
		case MyCases.forth:
			print("forth case");
			break;
		case MyCases.fifth:
			print("fifth case");
			break;
		case MyCases.sixth:
			print("sixth case");
			break;
		case MyCases.seventh:
			print("seventh case");
			break;
		default:
			print("other case");
			break;
		}
	}
}
