using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour
{

    public float distanceToSee;
    RaycastHit hit;
    public bool isholding = false;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isholding)
            {
                if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, distanceToSee))
                {
                    if (hit.collider.tag == "identable")
                    {
                        isholding = true;
                        GameObject g = hit.collider.gameObject;
                        g.GetComponent<Rigidbody>().useGravity = false;
                        g.GetComponent<Rigidbody>().isKinematic = true;
                        g.transform.parent = this.gameObject.transform;
                        g.transform.rotation = Quaternion.LookRotation(this.transform.right, this.transform.up);
                        g.transform.localPosition = new Vector3(0.7f, -0.7f, 1.5f);
                    }
                }
            }
            else
            {
                isholding = false;
                this.gameObject.GetComponentInChildren<Rigidbody>().useGravity = true;
                this.gameObject.GetComponentInChildren<Rigidbody>().isKinematic = false;
                this.gameObject.transform.DetachChildren();
            }
        }
    }
}
