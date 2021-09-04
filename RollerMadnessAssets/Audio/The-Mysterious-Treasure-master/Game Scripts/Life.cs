using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject heart;
	public GameObject Player;

	CharacterStats player;

	void Start () 
	{
		player = Player.GetComponent <CharacterStats> ();
	}


	void Update () 
	{
		RotateSpeed = 3;
		transform.Rotate (0, RotateSpeed, 0, Space.World);
	}

	void OnTriggerEnter () 
	{
		if (player.currentHealth <= 80) 
		{
			CollectSound.Play ();
			player.currentHealth += 20;
			heart.SetActive (false);
		}
	}
}
