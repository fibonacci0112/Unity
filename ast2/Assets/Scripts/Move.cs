using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	Rigidbody rb;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (0, -5f, 10f);

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rb.transform.position.y < 0) 
		{

			rb.AddForce(0,5f,0);
		}
		if (rb.transform.position.y >1.2) 
		{
			
			rb.AddForce(0,-5f,0);
		}
	
	}
}
