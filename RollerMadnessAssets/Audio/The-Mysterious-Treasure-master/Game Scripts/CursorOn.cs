using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorOn : MonoBehaviour {

	public static int count1,count2;
	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		count1 = 1;
		count2 = 1;
	}

	void Update()
	{
		if(Input.GetButtonDown("Pause") && count2 % 2 == 1)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			count2++;
		}

		else if(Input.GetButtonDown("Pause") && count2 % 2 == 0)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			count2++;
		}

		if(Input.GetButtonDown("Inventory") && count1 % 2 == 1)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			count1++;
		}

		else if(Input.GetButtonDown("Inventory") && count1 % 2 == 0)
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			count1++;
		}
	}
}
