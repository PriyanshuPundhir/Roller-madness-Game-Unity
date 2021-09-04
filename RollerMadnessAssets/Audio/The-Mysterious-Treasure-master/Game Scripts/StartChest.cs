using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChest : MonoBehaviour {
		
	Animator anim;
	public ParticleSystem GoldParticles;

	void Awake()
	{
		Time.timeScale = 1;
		anim = GetComponent<Animator> ();
		anim.SetTrigger ("OpenChest");
		GoldParticles.Play ();
	}
}
