using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

	public float radius = 2.0f;
	public float distance;
	public Transform interactionTransform;	
	public Transform player;
	public GameObject ObjectiveText;
	public GameObject ObjectiveImage;
	public bool isRead,check;

	void Start()
	{
		isRead = false;
		check = false;
		ObjectiveText.SetActive (false);
		ObjectiveImage.SetActive (false);
	}

	void Update()
	{
		distance = Vector3.Distance(player.position, interactionTransform.position);
		if(distance <= radius && check == false)
		{
			ObjectiveText.SetActive (true);
			if(Input.GetButtonDown("Action") && check == false)
			{
				check = true;
				ObjectiveImage.SetActive (true);
				ObjectiveText.SetActive (false);
			}
			else if(Input.GetButtonDown("Action")  && check == true)
			{
				check = false;
				isRead = true;
				ObjectiveImage.SetActive (false);
				ObjectiveText.SetActive (false);
			}
		}
		else if(Input.GetButtonDown("Action")  && check == true)
		{
			check = false;
			isRead = true;
			ObjectiveImage.SetActive (false);
			ObjectiveText.SetActive (false);
		}
		else
		{
			ObjectiveText.SetActive (false);
		}
			
	}
}
