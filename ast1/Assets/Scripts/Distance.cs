using UnityEngine;
using System.Collections;

public class Distance : MonoBehaviour {

	public float speed;
	public float limit;
	Transform tr;

	void Start () 
	{
		tr=GetComponent<Transform> ();
	}
	
	void Update () 
	{
		if (Input.GetAxis("Jump")>0&& this.transform.position.z<0)
		{
			tr.Translate(0,0,speed);
		}
		
		if (Input.GetAxis("Fire1")>0&& this.transform.position.z>-100 )
		{
			tr.Translate(0,0,-speed);
		}
	}
}
