using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public Transform canvas;
	public Transform pauseMenu;
	public GameObject Player;
	public GameObject Enemy;


	void Start () {
		
	}
	void Update () 
	{
		if (Input.GetButtonDown("Pause"))
		{
			PauseMenu();
		}
	}

	public void PauseMenu()
	{
		if (canvas.gameObject.activeInHierarchy == false)
		{
			if (pauseMenu.gameObject.activeInHierarchy == false)
			{
				pauseMenu.gameObject.SetActive(true);
			}
			canvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Player.SetActive (false);
			Enemy.SetActive (false);
		}
		else
		{
			canvas.gameObject.SetActive(false);
			Time.timeScale = 1;
			Player.SetActive (true);
			Enemy.SetActive (true);
		}
	}
}
