using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampOn : MonoBehaviour {

    Light theSource;
    MeshCollider collider;
    Camera holder;
    void Start () 
    {
        theSource = this.GetComponentInChildren<Light>();
        collider = this.GetComponentInChildren<MeshCollider>();
        holder = this.GetComponentInParent<Camera>();
	}
	
	void Update () {
        if(Input.GetButton("Fire1"))
        {
            theSource.enabled = true;
            collider.enabled = true;
        }else
        {
            theSource.enabled = false;
            collider.enabled = false;
        }
    }


}
