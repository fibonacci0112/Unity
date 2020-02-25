using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    bool activated = true;
    float a = 0;
    public float speed = .5f;
    void Start()
    {
        StartCoroutine(MoveBlock());
    }

    IEnumerator MoveBlock()
    {

        while (activated)
        {
            yield return new WaitForSeconds(0.2f);
            a += 22.5f;
                transform.rotation = Quaternion.Euler(0, a, 0);
        }
	}
}
