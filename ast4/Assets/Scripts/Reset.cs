using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	Vector3 v = new Vector3 (0, 0, 0);

	void OnCollisionEnter(Collision col)
	{
		//col.collider.transform.position.y = 5f;
	}
}
