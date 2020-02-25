using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamager : MonoBehaviour {

    MeshCollider theSource;
    EnemyHealth enem;
	void Start () 
    {
        theSource = GetComponent<MeshCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            if (!enem.isdead)
            {
                enem = other.gameObject.GetComponent<EnemyHealth>();
                enem.health--;
            }
        }
    }
}
