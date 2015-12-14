using UnityEngine;
using System.Collections;

public class VariablesandFunctions : MonoBehaviour
{
	int myInt = 5;

	
		void Start ()

	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}

	int MultiplyByTwo (int a)
	{
		int ret;
		ret = a * 2;
		return ret;
	}
}