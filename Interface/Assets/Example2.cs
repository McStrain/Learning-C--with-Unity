using UnityEngine;
using System.Collections;

public class Example2 : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        Toaster2 T = new Toaster2(); // create a new Toaster
        T.ThingName = "Talkie"; //set the toasters name
        print(T.ThingName); // check the toasters name
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
