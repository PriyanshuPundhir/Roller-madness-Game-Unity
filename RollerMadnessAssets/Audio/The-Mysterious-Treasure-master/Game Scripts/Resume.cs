using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour {

	public Transform canvas;
	public Transform pauseMenu;
	public GameObject Player;
	public GameObject Enemy;


	public void OnResume()
	{
		canvas.gameObject.SetActive(false);
		Time.timeScale = 1;
		Player.SetActive (true);
		Enemy.SetActive (true);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		CursorOn.count2++;
	}
		
	public void OnRestart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		canvas.gameObject.SetActive(false);
		Time.timeScale = 1;
		Player.SetActive (true);
		Enemy.SetActive (true);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	public void BackToMainMenu()
	{
		SceneManager.LoadScene (0);
	}
}
