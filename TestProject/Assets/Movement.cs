using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    float i;
    // Use this for initialization
    void Start () {

         i = 0;

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            i += 0.1f;
        }
        this.transform.position = new Vector3(0, 0, i);
        
    }
}
