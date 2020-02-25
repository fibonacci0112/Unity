using UnityEngine;
using System.Collections;

public class SatRotate : MonoBehaviour {

	Transform tr;
	public float x;
	public float y;
	public float swingy;
	public float swingx;
	public float addy;
	public float addx;

	void Start ()
	{
		tr = GetComponent<Transform> ();
	}

	void Update ()
	{
		tr.Rotate(0,y*swingy,0);
		tr.Rotate(x*swingx,0,0);
		swingy += addy;
		swingx += addx;
		
		if (swingy >1||swingy<0) 
		{
			addy*=-1;
		}
		if (swingx >1||swingx<0) 
		{
			addx*=-1;
		}
	}
}
