using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	string[] names = new string[] {"MrCube", "MrsCube", "MissCube", "CubeJr"};
	void Start()
	{
		float y = 1.0f;
		foreach (string s in names) 
		{
			print(s);
			CreateANamedObject(PrimitiveType.Cube, s, new Vector3(0, y, 0));
			y += 1.0f;;
		}
/*
		CreateANamedObject(PrimitiveType.Cube, names[0], new Vector3(0, 1, 0));
		CreateANamedObject(PrimitiveType.Cube, names[1], new Vector3(0, 2, 0));
		CreateANamedObject(PrimitiveType.Cube, names[2], new Vector3(0, 3, 0));
		CreateANamedObject(PrimitiveType.Cube, names[3], new Vector3(0, 4, 0));
*/
	}

	void CreateANamedObject(PrimitiveType pt, string n, Vector3 p)
	{
		GameObject g = GameObject.CreatePrimitive(pt);
		g.name = n;
		g.transform.position = p;
	}


/*
	int a = 0;
	float b = 0;
	// Use this for initialization
	void Start()
	{

	}
	void SetA (int i, float j)
	{
		a = i * j;
	}
*/





/*	void Start () {
		print(a);
		SetA (3);
		print(a);
	}
	
void SetA (int i)
	{
		a = i;
	}
}

class MySideEffect 
{
	int a = 0;
	void SetA()
	{
		a = 5;
	}

	void SetAgain()
	{
		a = new int();
	}
*/
}