using UnityEngine;
using System.Collections;

public class DogControl : MonoBehaviour
{
    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = gameObject.GetComponent<Animator>();
        GameManager.OnDuckDeath += PlayDuck;
        GameManager.OnDuckFlyAway += PlayLaugh;

	}

    // Update is called once per frame
    //void Update () {

    //}

    public void SpawnDucks()
    {
        Debug.Log("Dog Spawning");
        GameManager.OnDuckSpawn();
    }

    public void PlayLaugh()
    {
        anim.Play("DogLaugh");
        
    }

    public void PlayDuck()
    {
        anim.Play("DogDuckAnimation");
    }
}
