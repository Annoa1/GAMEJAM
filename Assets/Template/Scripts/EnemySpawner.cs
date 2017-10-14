using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	public float invocationSpeed = 0.001f;

	public Transform upMarker;
	public Transform buttomMarker;

	private const float bigScaleSize = 1.3f;

	private float upX;
	private float upY;

	private float buttomX;
	private float buttomY;

	void Start () {
		upX = upMarker.position.x;
		upY = upMarker.position.y;

		buttomX = buttomMarker.position.x;
		buttomY = buttomMarker.position.y;

		//Spawn des sandwichs en continue
		InvokeRepeating("InvokeEnemySpawn", 1, 1);
	}

	void Update () {
		
	}

	//délai de spawn d'un enemy
	void InvokeEnemySpawn()
	{
		Invoke("SpawnEnemy",Random.Range(10f, 20f));
		//Invoke("SpawnEnemy", 4f);
	}

	void SpawnEnemy()
	{
		//spawn au dessus de l'écran sur une longueur aléatoire
		Vector3 spawnPosition = new Vector3(Random.Range(upX, buttomX), Random.Range(upY, buttomY), enemy.transform.position.z);
		GameObject instance = Instantiate(enemy,spawnPosition, enemy.transform.rotation);

		//1 sandwich sur 10 rapporte plus de points
		/*if (Random.Range(0, 10) == 1)
		{
			instance.transform.localScale = new Vector3(bigScaleSize,bigScaleSize,bigScaleSize);
		}*/

		Destroy(instance, 10);
	}
}
