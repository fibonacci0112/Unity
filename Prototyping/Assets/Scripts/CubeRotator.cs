using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {
    public bool activated = false;
    Renderer rend;
    float a;
    Color myColor;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        a = transform.position.y;
        myColor = rend.material.color;
    }

    private void Update()
    {
        if (activated)
        {
            GravitySwitch(Input.GetMouseButtonDown(1));
            transform.rotation = Quaternion.Euler(GameObject.Find("FirstPersonCharacter").transform.rotation.eulerAngles.x*2, GameObject.Find("FirstPersonCharacter").transform.rotation.eulerAngles.y*2, GameObject.Find("FirstPersonCharacter").transform.rotation.eulerAngles.x*2);
        }

        if (Input.GetMouseButtonUp(0) && activated)
        {
            activated = false;
        }
    }

    private void GravitySwitch(bool onOff)
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("GameController");

        foreach (GameObject ball in balls)
        {
            ball.GetComponent<Rigidbody>().useGravity = onOff;
        }
    }
}
