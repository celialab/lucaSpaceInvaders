using UnityEngine;
using System.Collections;

public class Laser_script : MonoBehaviour {

	// Use this for initialization
	int speed=5;
	public Transform shield;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(new Vector3(0, speed*Time.deltaTime, 0));
		
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="Top")
			Destroy(gameObject);
		
		if (col.gameObject.tag=="Enemy")
		{
			if((int)Random.Range(1.0f, 5.0f)==1)
				Instantiate(shield, transform.position, Quaternion.identity);
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}
