using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour
{
	public GameObject[] spawnObject;
	public float xRange = 1.0f;
	public float zRange = 1.0f;
	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 10.0f;
	
	void Start()
	{
		Invoke("SpawnEnemy", Random.Range(minSpawnTime,maxSpawnTime));
	}
	
	void SpawnEnemy()
	{
		float xOffset = Random.Range(-xRange, xRange);
		float zOffset = Random.Range(-zRange, zRange);
		int spawnObjectIndex = Random.Range(0,spawnObject.Length);
		Instantiate(spawnObject[spawnObjectIndex],transform.position + new Vector3(xOffset,0.0f,zOffset), spawnObject[spawnObjectIndex].transform.rotation);
		Invoke("SpawnEnemy", Random.Range(minSpawnTime,maxSpawnTime));
	}
}
