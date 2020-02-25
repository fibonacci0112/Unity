using UnityEngine;
using System.Collections;

public class playsmoke : MonoBehaviour {

	ParticleSystem smoke;
	public string button;
	void Start () 
	{
		smoke=GetComponent<ParticleSystem> ();
	
	}
	
	void Update () 
	{
		if (Input.GetButtonDown(button))
		{
			smoke.Play();
		}
		if (Input.GetButtonUp(button))
		{
			smoke.Stop();
		}
	}
}
