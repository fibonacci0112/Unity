using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSphereScript : MonoBehaviour {

    bool activated = false;

    void HitByRayCast()
    {
        activated = true;
    }

    private void Update()
    {
        if (activated)
        {
            transform.SetParent(GameObject.Find("FirstPersonCharacter").transform);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && activated) // back
        {
            transform.localScale = new Vector3(transform.localScale.x + .01f, transform.localScale.y + .01f, transform.localScale.z + .01f);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0 && activated)
        {
            transform.localScale = new Vector3(transform.localScale.x - .01f, transform.localScale.y - .01f, transform.localScale.z - .01f);
        }

        if (Input.GetMouseButtonUp(0)&&activated)
        {
            this.gameObject.transform.SetParent(GameObject.Find("Drone1").transform);
            activated = false;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
