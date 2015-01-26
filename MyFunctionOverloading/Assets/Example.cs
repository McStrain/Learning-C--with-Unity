using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {
	public class Letters 
	{
		public static Vector3[] A = new[]{
			new Vector3(-1, -1, 0),
			new Vector3(-1, 0, 0),
			new Vector3(0, 1, 0),
			new Vector3(1, 0, 0),
			new Vector3(-1, 0, 0),
			new Vector3(1, 0, 0),
			new Vector3(1, -1, 0)
		};
		public static Vector3[] B = new[]{
			new Vector3(-1, -1, 0),
			new Vector3(-1, 1, 0),
			new Vector3(0, 1, 0),
			new Vector3(1, 0, 0),
			new Vector3(-1, 0, 0),
			new Vector3(1, 0, 0),
			new Vector3(1, -1, 0),
			new Vector3(-1, -1, 0)
		};
		public static Vector3[] C = new[]{  		//  I'm just putting this for a Default switch case so the code will not error out.
			new Vector3(0, 0, 0),
		};

		public static Vector3[] ToVectorArray(char c)
		{
			Vector3[] letter;
			switch(c)
			{
			case 'A':
				letter = A;
				break;
			case 'B':
				letter = B;
				break;
			default:
				letter = C;
				break;
			}
			return letter;
		}
		public static void drawWord(char c, float scale, Vector3 position, Color color)
		{
			Vector3[] lines = ToVectorArray (c);
			for (int i = 1; i < lines.Length; i++) {
				Vector3 start = (lines[i-1] * scale);
				Vector3 end = (lines[i] * scale);
				Debug.DrawLine(start + position, end + position, color);
			}
		}
		public static void drawWord(string word, float scale, Vector3 position, Color color)
		{
			// convert to uppercase first
			string uLetters = word.ToUpper ();
			char[] letters = uLetters.ToCharArray ();
			if (letters.Length > 0)
			{
				for(int i = 0; i < letters.Length; i++)
				{
					float offset = (i * scale);
					Vector3 offsetPosition = new Vector3(offset + position.x, position.y, position.z);
					drawWord (letters[i], scale, offsetPosition, color);
				}
			}
		}
	}






	/*
	GameObject CreateObject()
	{
		GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
		return g;
	}
	GameObject CreateObject(PrimitiveType pt)
	{
		GameObject g = GameObject.CreatePrimitive(pt);
		return g;
	}
	GameObject CreateObject(PrimitiveType pt, Vector3 loc)
	{
		GameObject g = GameObject.CreatePrimitive(pt);
		g.transform.position = loc;
		return g;
	}

	void Start()
	{
		GameObject a = CreateObject();
		GameObject b = CreateObject(PrimitiveType.Cylinder);
		GameObject c = CreateObject(PrimitiveType.Sphere, new Vector3 (2.0f, 3.5f, 1.3f));

	}
*/
	/*
	public static int Reloaded()
	{
		return 1;
	}
	public static int Reloaded(int a)
	{
		return a + 1;
	}
	public static float Reloaded (int a, float b)
	{
		return a / b;
	}
	public static void Reloaded(int a, ref float b)
	{
		b = (float) a/3;
	}

	public static double classInt = 13;  // class scoped number
	public static void Reloaded(double b)
	{
		classInt = b;
	}

	void Start() 
	{
		int a = Reloaded ();
		int b = Reloaded (3);
		float c = Reloaded (3, 2.0f);
		float d = 0;
		Reloaded (1, ref d);
		print (a);
		print (b);
		print (c);
		print (d);

		print (classInt);  // prints 13
		Reloaded (9.0);  // sets the classInt to 9.0
		print (classInt);  // print 9
	}
*/



	// Update is called once per frame
	void Update () 
	{
		Vector3 position = Vector3.zero;
		drawWord("words are being drawn", 2f, position, Color.black);
	}
}
