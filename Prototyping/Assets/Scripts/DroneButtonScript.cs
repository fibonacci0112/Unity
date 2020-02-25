using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneButtonScript : MonoBehaviour
{

    bool activated = false;
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void HitByRayCast()
    {
        activated = true;
    }

    private void Update()
    {
        if (activated)
        {
            rend.material.color = Color.white;
        }

        if (Input.GetMouseButtonUp(0) && activated)
        {
            rend.material.color = Color.gray;

            activated = false;
        }
    }
}
