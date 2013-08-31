using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour 
{
	public GameObject enemyType;
	public float spawnRadius = 10.0f;
	public float spawnDelay = 1.0f;
	
	// Use this for initialization
	void Start () 
	{
		Invoke ("SpawnEnemy",spawnDelay);
	}
	
	void SpawnEnemy()
	{
		Vector3 spawnPosition = transform.position + ((Vector3)Random.insideUnitCircle).normalized*spawnRadius;
		Instantiate(enemyType,spawnPosition,enemyType.transform.rotation);
		Invoke ("SpawnEnemy",spawnDelay);
	}
	
	void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(transform.position, spawnRadius);	
	}
	
}