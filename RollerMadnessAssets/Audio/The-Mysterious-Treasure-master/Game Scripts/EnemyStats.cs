using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyStats : CharacterStats {

	public GameObject character;
	public GameObject Player;
	public GameObject Text;
	public Item it;
	ItemPick obj;

	void Update()
	{
		CombatStats ();
	}

	public void CombatStats()
	{
		if (anim.GetBool ("Combat") == true)
		{
			if (Input.GetKeyDown (KeyCode.Mouse0)) 
			{
				TakeDamage (05);
			}
		}
	}

	public override void Die()
	{
		base.Die();
	
		anim.SetTrigger ("Die");

		anim.SetBool ("Combat", false);
 		Destroy (GetComponent<NavMeshAgent> ());
		Destroy (GetComponent<EnemyController> ());

		character.AddComponent<ItemPick> ();
		obj = character.GetComponent<ItemPick> ();
		obj.radius = 2f;
		obj.interactionTransform = character.transform;
		obj.player = Player.transform;
		obj.item = it;
		obj.ItemText = Text;


	}

}
