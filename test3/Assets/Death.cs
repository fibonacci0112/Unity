using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col)
	{
		GameObject obj = GameObject.Find ("Sphere");
		Ball ball = obj.GetComponent<Ball> ();

		ball.NeueRunde ();
	}
}
