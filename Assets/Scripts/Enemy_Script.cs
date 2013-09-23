using UnityEngine;
using System.Collections;

public class Enemy_Script : MonoBehaviour {

	// Use this for initialization
	public float speed=1;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,(-speed*Time.deltaTime ), 0));
	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="Button")
			Destroy(gameObject);	
		
	}
}
