using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour 
{
	private float heightTest = 3f;

	void Start ()
	{

		Debug.Log (transform.position.x);

		if(transform.position.x <= heightTest)

		{
			Debug.Log("I'm about to hit the ground!");
			FlyAway();
		}

		else if(transform.position.x >= heightTest)

		{
			Debug.Log("I'm flying!");
		}
	}

	public void FlyAway()

	{
		Debug.Log ("Fly Away!");
		Vector3 newPosition = new Vector3(0,7,0);
		transform.position = newPosition;
	}
}