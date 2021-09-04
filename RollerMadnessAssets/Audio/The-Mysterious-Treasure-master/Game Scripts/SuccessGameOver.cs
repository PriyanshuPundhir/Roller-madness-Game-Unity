using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessGameOver : MonoBehaviour {

	public AudioSource click;

	public void BackToMenu()
	{
		click.Play ();
		SceneManager.LoadScene (0);
	}
		
}
