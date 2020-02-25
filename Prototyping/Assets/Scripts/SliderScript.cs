using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour
{

    bool activated = false;
    float a;
    float rotated;
    public float upperbound;
    public float lowerbound;
    public float rotation;
    public string parent;
    void HitByRayCast()
    {
        activated = true;
        a = 0.3f;
    }

    private void Update()
    {
        if (activated)
        {
            if (GameObject.Find("FirstPersonCharacter").transform.rotation.eulerAngles.y != rotated)
            {
                if (transform.localPosition.x > upperbound )
                {
                    transform.localPosition = new Vector3(upperbound, transform.localPosition.y, transform.localPosition.z);

                }
                else if (transform.localPosition.x < lowerbound)
                {
                    transform.localPosition = new Vector3(lowerbound, transform.localPosition.y, transform.localPosition.z);

                }
                else
                {
                    transform.position = new Vector3(transform.position.x + ((rotated - GameObject.Find("FirstPersonCharacter").transform.rotation.eulerAngles.y) * 0.02f), transform.position.y, transform.position.z);
                }
            }
        }
        rotated = GameObject.Find("FirstPersonCharacter").transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Euler(rotation, 0, 0);

        if (Input.GetMouseButtonUp(0) && activated)
        {
            this.gameObject.transform.SetParent(GameObject.Find(parent).transform);
            activated = false;
        }
    }
}
