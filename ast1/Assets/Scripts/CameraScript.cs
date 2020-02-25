using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float speed;
	Transform tr;
	void Start ()
	{
		tr = GetComponent<Transform> ();
		
	}
	

	void Update () 
	{
		if (Input.GetAxis("Horizontal")<0 )
		{
			tr.Rotate(0,speed,0);
		}
		
		if (Input.GetAxis("Horizontal")>0 )
		{
			tr.Rotate(0,-speed,0);
		}
		
		if (Input.GetAxis("Vertical")<0 )
		{
			tr.Rotate(speed,0,0);
		}
		
		if (Input.GetAxis("Vertical")>0 )
		{
			tr.Rotate(-speed,0,0);
		}
		speed += 0.0001f;
	}
}
