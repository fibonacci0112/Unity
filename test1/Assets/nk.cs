using UnityEngine;
using System.Collections;

public class nk : MonoBehaviour {


	public float thrust;
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.AddForce (200f, 300f, 0);
	}

	
	// Update is called once per frame
	void Update () {
	
	}

}
