using UnityEngine;
using System.Collections;

public class GridScript : MonoBehaviour {

	public GameObject cube;


	void Start () 
	{

	}
	

	void Update () 
	{
		if (GameControl.counter == 0) 
		{
			CreateGrid ();
		}
		if (GameControl.time<0)
		{
			//this.EndRound();
			Debug.Log("jetzt");
		}
	}



	void CreateGrid()
	{
		for (int i = 0; i < 10; i++) 
		{
			for (int j = 0; j < 10; j++) 
			{
				if (Random.Range(0,5)==1)
				{
					Spawncube(new Vector3(i,j,0));
					GameControl.counter++;
				}
			}
		}
	}


	public void EndRound()
	{
		for (int i = GameControl.counter - 1; i > 0; i--)	
		{
			Destroy(GameObject.FindWithTag("Clone"));
		}  
	}


	void Spawncube(Vector3 pos)
	{
		GameObject newCube = (GameObject)Instantiate (cube, pos, Quaternion.identity);
	}

}
