﻿using UnityEngine;
using System.Collections;

public class DirectionChanger : MonoBehaviour {

	public enum dirChanger {Horizontal, Vertical};
	public dirChanger changer;
	
	void Start () 
	{
	
	}
	
	
	void Update () 
	{
	
	}
	
	void OnCollisionEnter (Collision hit)
	{
		if(hit.transform.tag == "Duck")
		{
			//creat duck movement variable. assign using GetComponent of hit
			DuckMovement movement = hit.gameObject.GetComponent<DuckMovement>();
		
			if(changer == dirChanger.Horizontal)
			{
				movement.DirectionChanger (new Vector3 (-1, 1, 0));
			}
		
			else if(changer == dirChanger.Vertical)
			{
				movement.DirectionChanger (new Vector3 (1, -1, 0));
			}
		}
	}
}
