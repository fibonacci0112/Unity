using UnityEngine;
using System.Collections;

public class PlayKey : MonoBehaviour {

	public AudioSource ton;

	void Start () 
	{
		ton = GetComponent<AudioSource> ();
	}
	
	void OnMouseDown()
	{
		ton.Play ();

	}
}
