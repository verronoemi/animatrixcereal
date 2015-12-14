using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour 
{

	public GameObject duck;
	

	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}
	
	public void SpawnDuck()
	{
		Debug.Log ("Spawn Duck");
		//create the instantiate
		Instantiate(duck, transform.position, Quaternion.identity); 
	}
}
