using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

	public GameObject player;
	#region Singleton

	public static PlayerManager instance;

	void Awake ()
	{
		Time.timeScale = 1;
		instance = this;
	}
		
	#endregion

	public void KillPlayer ()
	{
		SceneManager.LoadScene (5);
	}

}
