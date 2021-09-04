using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	public float lookRadius = 5f;	
	Animator anim;
	Transform target;	
	NavMeshAgent agent;
	CharacterCombat combat;

	void Start () 
	{
		target = PlayerManager.instance.player.transform;
		agent = GetComponent<NavMeshAgent>();
		combat = GetComponent<CharacterCombat>();
	}

	void Awake()
	{
		anim = GetComponent<Animator> ();
	}

	void Update () {

		float distance = Vector3.Distance(target.position, transform.position);
		if (distance <= lookRadius)
		{
			anim.SetBool ("EnemyWalk",true);
			agent.SetDestination(target.position);

			if (distance <= agent.stoppingDistance)
			{
				anim.SetBool ("Action",true);
				CharacterStats targetStats = target.GetComponent<CharacterStats>();
				if (targetStats != null)
				{
					combat.Attack(targetStats);
					anim.SetBool ("Action",true);
					anim.SetBool ("Combat",true);
				}
				FaceTarget();	
			}

			else if (distance > agent.stoppingDistance)
			{
				anim.SetBool ("EnemyWalk", true);
				anim.SetBool ("Action", false);
				anim.SetBool ("Combat",false);
			}
		}
	}

	void FaceTarget ()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
	}
		
	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, lookRadius);
	}
}
