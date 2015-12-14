﻿using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour 
{
	public float speed;
	public Vector3 direction;

    public int bounce;
    public int bounceMax;
	
	// Use this for initialization
	void Start () 
	{
        GameManager.OnDuckShot += StopMovement;
        GameManager.OnDuckMiss += DuckFlyAway;
		RandomDirection();
	}
	
	// Update is called once per frame
	public void FixedUpdate () 
	{
		transform.position = transform.position + (direction * speed);
		
	}
	
	public void RandomDirection()
	{
		direction = new Vector3 (Random.Range(-1f, 1f), Random.Range(.2f, 1f), 0);
	}
	
	public void DirectionChanger(Vector3 _dir)
	{
		direction = new Vector3 (direction.x * _dir.x, direction.y * _dir.y, 0);

        bounce++;

        if(bounce >= bounceMax)
        {
            direction = new Vector3(0, 1, 0);
            GameManager.OnDuckMiss();
        }
	}

    public void StopMovement()
    {
        direction = new Vector3(0, 0, 0);
    }

    public void StartFall()
    {
        direction = new Vector3(0, -1, 0);
    }

    public void DuckFlyAway()
    {
        direction = new Vector3(0, 1, 0);
    }
}
