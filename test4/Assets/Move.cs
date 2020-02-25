using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed=100;
	Rigidbody rb;
	void Start ()
	{
		rb=GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetAxis("Horizontal")<0 )
		{
			rb.AddForce(0,0,-10f);
		}
		
		if (Input.GetAxis("Horizontal")>0 )
		{
			rb.AddForce(0,0,10f);
		}
		
		if (Input.GetAxis("Vertical")<0 )
		{
			rb.AddForce(10f,0,0);
		}
		
		if (Input.GetAxis("Vertical")>0 )
		{
			rb.AddForce(-10f,0,0);
		}
	}
}
