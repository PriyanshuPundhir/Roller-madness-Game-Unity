using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public int no;
	public float SpawnRadius;
	public Vector3 SpawnPosition;
	public float SpawnTime = 2f;
	int select = 1;
	public Objective obj;


	void Start()
	{
		
		InvokeRepeating ("SpawnEnemy", SpawnTime, SpawnTime);
	}

	void SpawnEnemy()
	{
		if (obj.isRead == true) 
		{
			for (int i = 0; i < no; i++) {
				if (select <= 2)
					select++;
				else
					select = 0;
				SpawnPosition = transform.position + Random.insideUnitSphere * SpawnRadius;
				if (select == 1) 
				{
					Debug.Log ("ssss");
					Instantiate (enemy1, SpawnPosition, Quaternion.identity);
				}
				else if (select == 2)
					Instantiate (enemy2, SpawnPosition, Quaternion.identity);
				else if (select == 3)
					Instantiate (enemy3, SpawnPosition, Quaternion.identity);
			}
		}
			
	}
}
