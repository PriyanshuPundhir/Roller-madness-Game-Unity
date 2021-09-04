using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour {

	Animator anim;
	float ActionSelect = 0.0f;


	void Update () {
		Action ();
	}
		
	void Awake()
	{
		anim = GetComponent<Animator> ();	
	}
		
	void Action()
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			anim.SetTrigger ("Action");
			anim.SetBool ("Combat", true);
			anim.SetFloat ("ActionSelect", ActionSelect);

			if (ActionSelect >= 1)
				ActionSelect = 0.0f;
			else
				ActionSelect += 0.25f;
				
		}
	}
}