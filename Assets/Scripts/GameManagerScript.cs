using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {
	
	public int TotalShip;
	public int ShipKilled;
	public Transform enemyShip;
	public Transform playerShip;
	public int playerLives;
	public GameObject player;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(player == null && playerLives>=1)
		{
			playerLives--;
			Instantiate(playerShip, new Vector3(0,-4.35f,0), Quaternion.identity);
			player = GameObject.FindGameObjectWithTag("Player");
		}
	}
}
