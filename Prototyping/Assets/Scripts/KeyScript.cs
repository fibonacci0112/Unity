using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

    bool activated = false;
    Renderer rend;
    float a;
    Color myColor;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        a = transform.position.y;
        myColor = rend.material.color;
    }

    void HitByRayCast()
    {
        activated = true;
    }

    private void Update()
    {
        if (activated)
        {
            rend.material.color = new Color(0.6f,0.2f,0.2f);
            transform.position = new Vector3(transform.position.x,a-0.01f,transform.position.z);
        }

        if (Input.GetMouseButtonUp(0) && activated)
        {
            rend.material.color = myColor;
            transform.position = new Vector3(transform.position.x,a, transform.position.z);

            activated = false;
        }
    }
}
