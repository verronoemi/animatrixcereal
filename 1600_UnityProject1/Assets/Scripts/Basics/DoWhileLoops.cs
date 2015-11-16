using UnityEngine;
using System.Collections;

public class DoWhileLoops : MonoBehaviour 
{ //dowhile loops

	void Start () 
	{
		bool shouldContinue = false;

		do { 
			print ("Hello World");
		} while(shouldContinue == true);
	}

}
