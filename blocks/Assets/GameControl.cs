using UnityEngine;
using System.Collections;

public class GameControl: MonoBehaviour {



	public static float time=3.0f;
	public static int counter=0;
	public static int score=0;


	void Start () 
	{
	
	}
	

	void Update () 
	{
		if (GameControl.time>0)
		{
			time -= Time.deltaTime;
		}
		else
		{
			time=0.0f;			
		}
	}

	void OnGUI () 
	{
		GUI.Label (new Rect (10, 10, 100, 30), Mathf.Round (time).ToString());
		GUI.Label (new Rect (10, 40, 100, 30), score.ToString());
	}
}
