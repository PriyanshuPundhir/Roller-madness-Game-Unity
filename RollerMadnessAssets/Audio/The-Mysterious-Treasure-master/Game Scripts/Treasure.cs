using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Treasure : MonoBehaviour {

	public float radius = 2.0f;
	public float distance;
	bool ChestOpen = false;
	public GameObject TreasureText;
	public Transform interactionTransform;	
	public Transform player;
	public GameObject SuccessText;
	Animator anim;

	public ParticleSystem GoldParticles;

	Inventory invent;

	void Start()
	{
		GoldParticles.Stop ();
		anim = GetComponent<Animator> ();
		TreasureText.SetActive (false);
		SuccessText.SetActive (false);
	}

	void Update()
	{
		invent = InventoryUI.inventory;

	    distance = Vector3.Distance(player.position, interactionTransform.position);
		if (distance <= radius && ChestOpen != true)
		{
			if(invent.items.Count >= 12)
			{
				TreasureText.SetActive (true);
				if (Input.GetButtonDown ("Action")) 
				{
					ChestOpen = true;
					anim.SetTrigger ("OpenChest");
					GoldParticles.Play ();
					Destroy (player.GetComponent<EnemySpawn> ());
					TreasureText.SetActive (false);
					SuccessText.SetActive (true);
				}
			}
		}

		else if(distance > radius)
		{
			TreasureText.SetActive (false);
		}
		if (ChestOpen == true && Input.GetKeyDown(KeyCode.T))
			SceneManager.LoadScene (4);
	}
		
}
