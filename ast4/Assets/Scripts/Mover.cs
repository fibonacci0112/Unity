using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Mover : MonoBehaviour {

	public float speed = 30f;


	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update() 
	{
		
		
		if (Input.GetAxis("Horizontal")<0 )
		{
			transform.Rotate(0,0,speed*Time.deltaTime);
		}
		
		if (Input.GetAxis("Horizontal")>0 )
		{
			transform.Rotate(0,0,-speed*Time.deltaTime);
		}
		
		if (Input.GetAxis("Vertical")<0 )
		{
			transform.Rotate(-speed*Time.deltaTime,0,0);
		}
		
		if (Input.GetAxis("Vertical")>0 )
		{
			transform.Rotate(speed*Time.deltaTime,0,0);
		}
	}
}
