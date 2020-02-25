using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour  
{
	public Transform ballObject;    
	public float distance = 0.1f; // min distance to refresh view direction
	
	Vector3 lastPos;
	Vector3 viewDir;
	
	void Start(){
		// ensure forward direction at start
		lastPos = ballObject.transform.position - transform.forward * distance; 
	}        
	
	void Update() 
	{
		Vector3 ballPos = ballObject.transform.position;
		Vector3 newDir = ballPos - lastPos;  // direction from last position
		newDir.y = 0;    // keep the camera on horizontal plane
		if (newDir.magnitude>distance){  // only recalculate after min distance
			viewDir = newDir;
			lastPos = ballPos;
		}
		transform.position = ballPos;
		transform.forward = Vector3.Slerp(transform.forward, viewDir.normalized, Time.deltaTime);
	}
}
