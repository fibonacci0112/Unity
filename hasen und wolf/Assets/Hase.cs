using UnityEngine;
using System.Collections;

public class Hase : MonoBehaviour {

    float vel;

    public float thrust;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(200f, 300f, 0);
    }

    float x =1;
        float y=1;
        //vel = Mathf.PerlinNoise(x, y);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.GetComponent<Rigidbody>().velocity.x += vel;
	}
}
