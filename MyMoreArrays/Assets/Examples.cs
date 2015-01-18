using UnityEngine;
using System.Collections;

public class Examples : MonoBehaviour {


	// Use this for initialization
	void Start () {
		int[] primes = {1,3,5,7,11,13,17,23,27,31};
		int[] fibonacci = {0,1,1,2,3,5,8,13,21,34,55,89,144};
		int[] powersOfTwo = {1,2,4,8,16,32,64,128,256,512,1024};

		ArrayList Numbers = new ArrayList{primes, fibonacci, powersOfTwo};
		object[] thing = Numbers.ToArray() as object[];
		print (thing.Length);


/*		int numArrays = Numbers.Count;

		foreach (int[] Nums in Numbers)
		{
			foreach(int n in Nums)
			{
				print (n);
			}
		}
*/
	//	int items = primes.Length;

	//	for (int i = 0; i < items; i++) 
	//	{
	//		print (primes[i]);
	//	}

	//	int j = 0;
	//	while (j < items)
	//	{
	//		print (primes [j]);
	//		j++;
	//	}
	
	}
	

}
