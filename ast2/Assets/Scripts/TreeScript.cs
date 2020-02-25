using UnityEngine;
using System.Collections;


public class TreeScript : MonoBehaviour {

	public Tree tree;
	public AudioSource source;
	public Camera cam;
	void Start () 
	{

		source.pitch = ((tree.transform.position.x-cam.transform.position.x)/130)+.5f;

	}
	

	void Update () 
	{
	}
}
