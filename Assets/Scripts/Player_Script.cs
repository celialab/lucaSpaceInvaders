using UnityEngine;
using System.Collections;

public class Player_Script : MonoBehaviour {
	
	int Healt=100;
	int Speed=5;
	GameObject collider_width=null;
	float fireRate=0.4f;
	float nexshot=0.0f;
	public Transform Laser_pref;
	bool powerUp=false;
	bool PowerUp
	{
		get{return powerUp;}
		set
		{
			if(value)
				renderer.material.mainTextureOffset=new Vector2(0,0);//verde
			else
				renderer.material.mainTextureOffset=new Vector2(0,0.5f);//no verde
			powerUp=value;
		}
		
	}
	
	
	
	// Use this for initialization
	void Start () 
	{	}	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetAxis("Horizontal")>0)
		{
			if(collider_width!=null)
			{
				if (collider_width.tag=="Left")
				{
					return;
				}
			}
			transform.Translate(new Vector3(Input.GetAxis("Horizontal")*Speed*Time.deltaTime,0,0));			
		}
		if(Input.GetAxis("Horizontal")<0)
		{
			if(collider_width!=null)
			{
				if (collider_width.tag=="Right")
				{
					return;
				}
			}
			transform.Translate(new Vector3(Input.GetAxis("Horizontal")*Speed*Time.deltaTime,0,0));			
		}
		if(Input.GetAxis("Fire_laser")>0)
		{
			print (Time.time);
			if(Time.time>= nexshot)
			{
			Instantiate(Laser_pref, new Vector3(transform.position.x, transform.position.y+1,0), Quaternion.identity);
				nexshot= Time.time+fireRate;
			}
			
		}
	}
	
	void OnCollisionEnter(Collision collision) 
	{	
		collider_width=collision.gameObject;
		
		if(collision.gameObject.tag=="Enemy")
		{
			
			Destroy(collision.gameObject);
			if(PowerUp==false)
				Destroy(gameObject);
			else
				PowerUp=false;
			
		}
		if(collision.gameObject.tag=="Shield")
		{
			Destroy(collision.gameObject);
			PowerUp=true;
		}
	}
	 void OnCollisionExit(Collision collisionInfo) 
	{
		collider_width=null;
	}
}
