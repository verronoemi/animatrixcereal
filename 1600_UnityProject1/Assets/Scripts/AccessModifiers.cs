using UnityEngine;
using System.Collections;

public class AccessModifiers : MonoBehaviour 
{
	public int balloons = 5;
	
	private FlyScript otherClass;
	
	void Start () 
	{
		balloons = 35;
		
		//otherClass = new FlyScript();
		//otherClass.FlyAway;
	}
}