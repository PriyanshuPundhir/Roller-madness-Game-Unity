using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour {

	int count;
	void Start () 
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		count = 1;
	}

	/*void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse1) && count % 2 == 1) 
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			count++;
		}
		else if(Input.GetKeyDown (KeyCode.Mouse1) && count % 2 == 0)
		{
			//Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			count++;
		}
	}*/
}
