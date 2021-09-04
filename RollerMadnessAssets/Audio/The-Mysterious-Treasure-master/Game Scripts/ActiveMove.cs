using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMove : MonoBehaviour {

	public ActiveItems focus;
	Camera cam;
	void Start()
	{
		cam = Camera.main;
	}

	void Update () {
		
		FocusCheck ();
	}
		
	void FocusCheck()
	{
		Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, 100))
		{
			ActiveItems interactable = hit.collider.GetComponent<ActiveItems>();
			if (interactable != null)
			{
				SetFocus(interactable);
			}
		}
	}

	void SetFocus (ActiveItems newFocus)
	{
		if (newFocus != focus)
		{
			if (focus != null)
				focus.OnDefocused();

			focus = newFocus;	
		}
		newFocus.OnFocused(transform);
	}
		
	void RemoveFocus ()
	{
		if (focus != null)
			focus.OnDefocused();

		focus = null;
	}
}
