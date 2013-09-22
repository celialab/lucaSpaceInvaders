using UnityEngine;
using System.Collections;

public class Laser_script : MonoBehaviour {

	// Use this for initialization
	int speed=5;
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
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}
