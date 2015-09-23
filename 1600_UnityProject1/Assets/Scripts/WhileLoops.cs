using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour 
{ //while loop
	int cupsInTheSink = 4;

	void Start ()
	{
		while (cupsInTheSink > 0) {
			cupsInTheSink--;
			Debug.Log ("I washed a cup");
		}
	}
}