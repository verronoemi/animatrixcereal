using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour 
{ //forloops
	int numEnemies = 3;

	void Start () 
	{
		for (int i = 0; i < numEnemies; i++) 
		{
			Debug.Log ("creating enemy number" + i);
		}
	}
}
