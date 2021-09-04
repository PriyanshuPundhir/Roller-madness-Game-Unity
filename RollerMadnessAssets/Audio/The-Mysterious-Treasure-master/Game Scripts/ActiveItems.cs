using UnityEngine;

public class ActiveItems : MonoBehaviour {

	public float radius = 1f;
	public Transform interactionTransform;	
	public GameObject ItemText;
	bool isFocus = false;	
	public Transform player;		
	bool hasInteracted = false;	
	public float distance;
	void Start()
	{
		ItemText.SetActive (false);
	}

	public virtual void Interact()
	{
		Debug.Log("Interacting with " + transform.name);
		ItemText.SetActive (false);
	}

	void Update ()
	{
		if (!hasInteracted)
		{
			 distance = Vector3.Distance(player.position, interactionTransform.position);
			if (distance <= radius)
			{
				ItemText.SetActive (true);
				if (Input.GetButtonDown ("Action")) 
				{
					Interact ();
					hasInteracted = true;
				}
			}
			else
			{
				ItemText.SetActive (false);
				hasInteracted = false;
			}
		}
	}
		
	public void OnFocused (Transform playerTransform)
	{
		isFocus = true;
		Debug.Log ("Focused");
		player = playerTransform;
		hasInteracted = false;
	}
		
	public void OnDefocused ()
	{
		isFocus = false;
		Debug.Log ("DE Focused");
		player = null;
		hasInteracted = false;
	}


	void OnDrawGizmosSelected ()
	{
		if (interactionTransform == null)
			interactionTransform = transform;

		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(interactionTransform.position, radius);
	}
}
