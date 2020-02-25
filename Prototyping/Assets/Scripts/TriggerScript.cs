using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

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
        if (activated && rend.material.color==Color.white)
        {
            rend.material.color = Color.yellow;
            activated = false;
        }

        if (activated && rend.material.color == Color.yellow)
        {
            rend.material.color = Color.white;
            activated = false;
        }
    }
}
