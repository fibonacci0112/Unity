using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{

    public int health;
    public bool isdead;

	void Start () 
    {
        health = 100;
        isdead = false;

	}
	
	void Update () 
    {
        if(health==0)
        {
            isdead = true;
        }
        if(isdead)
        {
            Debug.Log("ich bin tot");
        }
	}
}
