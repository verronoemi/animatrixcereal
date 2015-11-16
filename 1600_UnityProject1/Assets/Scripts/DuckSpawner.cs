using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour 
{

	public GameObject duck;
	

	void Start () 
	{
	
	}
	
	// Update is called once per frame
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
