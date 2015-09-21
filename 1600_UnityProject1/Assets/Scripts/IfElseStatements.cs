using UnityEngine;
using System.Collections;

public class IfElseStatements : MonoBehaviour 
{
	public float coffeeTemperature = 85.0f;
	public float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;
		
		
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
			
			coffeeTemperature -= Time.deltaTime * 5f;
	}
		
		
	void TemperatureTest ()
	{
		if (coffeeTemperature > hotLimitTemperature) 
		{
			print ("Too Hot");
		} else if (coffeeTemperature < coldLimitTemperature) 
		{
			print ("Too Cold");
		}
		else 
		{
			print ("Just Right");
		}
	}
}					      