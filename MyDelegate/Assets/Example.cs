using UnityEngine;
using System.Collections;
public class Example : MonoBehaviour {
    	delegate void MyDelegate(int a);
    	public MyDelegate del;
    	
    	void FirstDelegate(int a)
    	{
    		Debug.Log("first delegate: " + a);
    	}
    	
    	void SecondDelegate(int a)
    	{
    		Debug.Log("second delegate: " + a);
    	} 
    	
    	void Start()
    	{
    		if (del == null)
    		{
    			del += FirstDelegate;
    			del += SecondDelegate;
    			del(3);	//prints "first delegate: 3"
    			//and "second delegate: 3"
    		}
    	}
	 //Update is called once per frame
	void Update () 
    {
	
	}
}
