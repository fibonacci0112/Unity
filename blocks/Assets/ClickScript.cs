using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickScript : MonoBehaviour {


	Rigidbody rb;
	BoxCollider bc;

	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		bc = GetComponent<BoxCollider> ();
	}
	



	void OnMouseDown()
	{
		transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z-1);
		rb.isKinematic = false;
		rb.AddForce(new Vector3(0,0,Random.Range(-300,-150)));
		rb.AddTorque (Random.Range(-50,50), Random.Range(-50,50),Random.Range(-50,50));
		rb.useGravity = true;
		bc.enabled = false;
		GameControl.counter--;
		GameControl.score++;
	}
}
