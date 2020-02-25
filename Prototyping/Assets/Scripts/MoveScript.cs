using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    bool activated = true;
    float a = 0.9375f;
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
            a -= 0.125f;
            if (a < -0.9375f)
            {
                a = 0.9375f;
            }
            //transform.position = GetComponentInParent<Transform>().position;
            transform.localPosition = new Vector3(a, transform.localPosition.y, transform.localPosition.z);
            //Debug.Log(transform.position);
        }

    }

}
