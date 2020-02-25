using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour 
{

	Ray ray;
	RaycastHit hit;
	public GameObject prefab;
	int count;

	void Start () 
	{
	}
	

	void Update () 
	{
		ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if(Physics.Raycast(ray,out hit))
		{
			if(Input.GetMouseButtonDown(0)&&hit.collider.gameObject.name=="Terrain"&&count<10)
			{
				GameObject obj=Instantiate(prefab,new Vector3(hit.point.x,hit.point.y,hit.point.z), Quaternion.identity) as GameObject;
				count++;

			}
			if (hit.collider.gameObject.name=="Tree(Clone)"&&Input.GetMouseButtonDown(0)) 
			{
				Destroy(hit.collider.gameObject);
				count--;
			}
		}
	}
}
