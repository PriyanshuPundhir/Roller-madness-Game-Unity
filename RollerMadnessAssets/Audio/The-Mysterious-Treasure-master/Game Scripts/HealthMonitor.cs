using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class HealthMonitor : MonoBehaviour {

	public static int HealthValue;
	public GameObject Heart1;
	public GameObject Heart2;
	public GameObject Heart3;
	public GameObject Heart4;
	public GameObject Heart5;
	public GameObject Player;
	public GameObject blood;
	CharacterStats player;

	void Start () 
	{
		player = Player.GetComponent <CharacterStats> ();
		HealthValue = player.maxHealth;
	}


	void Update () 
	{
		HealthValue = player.currentHealth;

		if(HealthValue <= 0)
		{
			Heart1.SetActive (false);
			Heart2.SetActive (false);
			Heart3.SetActive (false);
			Heart4.SetActive (false);
			Heart5.SetActive (false);
		}

		else if (HealthValue > 0 && HealthValue <= 20) 
		{
			Heart1.SetActive (true);
			Heart2.SetActive (false);
			Heart3.SetActive (false);
			Heart4.SetActive (false);
			Heart5.SetActive (false);
		}
		else if (HealthValue > 20 && HealthValue <= 40) 
		{
			blood.GetComponent<BloodRainCameraController> ().Attack (50);
			Heart1.SetActive (true);
			Heart2.SetActive (true);
			Heart3.SetActive (false);
			Heart4.SetActive (false);
			Heart5.SetActive (false);
		}
		else if (HealthValue > 40 && HealthValue <= 60) 
		{
			blood.GetComponent<BloodRainCameraController> ().Reset ();
			Heart1.SetActive (true);
			Heart2.SetActive (true);
			Heart3.SetActive (true);
			Heart4.SetActive (false);
			Heart5.SetActive (false);
		}
		else if (HealthValue > 60 && HealthValue <= 80) 
		{
			blood.GetComponent<BloodRainCameraController> ().Reset ();
			Heart1.SetActive (true);
			Heart2.SetActive (true);
			Heart3.SetActive (true);
			Heart4.SetActive (true);
			Heart5.SetActive (false);
		}
		else if (HealthValue > 80 && HealthValue <= 100) 
		{
			blood.GetComponent<BloodRainCameraController> ().Reset ();
			Heart1.SetActive (true);
			Heart2.SetActive (true);
			Heart3.SetActive (true);
			Heart4.SetActive (true);
			Heart5.SetActive (true);
		}

	}
}