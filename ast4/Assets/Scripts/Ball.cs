using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	Rigidbody rb;
	AudioSource aud;
	public float speed=100f;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		aud = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton ("Jump")) {
			rb.useGravity = true;
		} else 
		{
			rb.useGravity=false;
		}
	
	}

	void OnCollisionEnter(Collision col)
	{

		aud.Play ();
	}
}
