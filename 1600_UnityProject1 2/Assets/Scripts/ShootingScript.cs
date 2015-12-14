using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    RaycastHit hit;

    private int bulletAmt;
    public int maxBullets;

	// Use this for initialization
	void Start ()
    {
        GameManager.OnDuckSpawn += ResetBullets;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bulletAmt--;

            if (bulletAmt <= 0)
            {
                GameManager.OnDuckMiss();
            }
        }

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.z;

        if (Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Duck")
            {
                hit.transform.GetComponent<DuckHealth>().KillDuck();
                //DuckHealth duckHealth = GetComponent<DuckHealth>();
                //duckHealth.KillDuck();
            }
        }
    }

    public void ResetBullets ()
    {
        bulletAmt = maxBullets;
    }
}
