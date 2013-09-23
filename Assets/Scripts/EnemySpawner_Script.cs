using UnityEngine;
using System.Collections;

public class EnemySpawner_Script : MonoBehaviour 
{
	int direction = 1;
	float speed = 3 ;
	public Transform enemy;
	float lastSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(new Vector3(direction*speed*Time.deltaTime,0,0));		
		if(Time.time> lastSpawn)
		{
			Instantiate(enemy, transform.position, Quaternion.identity);
			lastSpawn=Time.time+1.5f;
				
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="Left")
			direction = (-1);
		else if (col.gameObject.tag=="Right")
			direction = 1;
	}
}
