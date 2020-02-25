using UnityEngine;
using System.Collections;

public class player : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetAxis("Horizontal")<0) 
		{

			transform.Translate(6f*Time.deltaTime,0,0);
		}

		if (Input.GetAxis("Horizontal")>0) 
		{

			transform.Translate(-6f*Time.deltaTime,0,0);
		}
	
	}
}
