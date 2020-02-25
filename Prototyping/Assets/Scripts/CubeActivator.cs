using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeActivator : MonoBehaviour {

    void HitByRayCast()
    {
        GetComponentInParent<CubeRotator>().activated = true;
    }
}
