using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour 
{
	public int score; 
	
	void Update()
	{
		switch(score)
		{
			case 5:
				print ("Excellent");
				break;
			case 4:
				print ("G0od job");
				break;
				
				//... cases
				
			default:
				print ("NOthing scored");
				break;
		}
	}
}
