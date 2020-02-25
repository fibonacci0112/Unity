using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Ball : MonoBehaviour {

	Rigidbody rb;
	Transform tr;
	int score;
	int highscore;
	public Text counttext;
	public Text highscorecount;
	public AudioSource a;
	
	
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
		highscore = 0;
		NeueRunde ();
	}
	
	public void NeueRunde ()
	{
		score = 0;
		Scores (1);
		Scores (2);
		tr.position = new Vector3 (0, 5, 0);
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		rb.AddForce (Random.Range(-50f,50f),0,Random.Range(-50f,50f));



	}
	
	
	void Update () 
	{
		
	}

	void OnCollisionEnter()
	{

		a.Play ();
		score++;
		Scores (1);
		if (score>highscore) 
		{
			highscore=score;
			Scores (2);
			Debug.Log (highscore);
		}
	}

	void Scores(int a)
	{
		switch (a) 
		{
		case 1:
			counttext.text = "Points: " + score;
			break;
		case 2:
			highscorecount.text = "Highscore: " + highscore;
			break;
		default:
			break;
		}
	}

}
