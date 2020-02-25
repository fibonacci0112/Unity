using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health;
	void Start () 
    {
        health = 100;
	}
	
	void Update () 
    {
        if(health < 100)
        {
            health+=1;
        }
        if(health<0)
        {
            Debug.Log("tot");
            Destroy(this.gameObject);
        }
	}
}
