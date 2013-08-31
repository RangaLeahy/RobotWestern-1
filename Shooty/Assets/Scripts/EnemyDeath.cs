using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour 
{
	public GameObject gib;
	public int amount = 10;
	public float spawnRadius = 0.5f;
	public float explosionRadius = 1.0f;
	public float explosionForce = 500f;
	
	void OnCollisionEnter()
	{
		for(int i = 0; i < amount; i++)
		{
			Vector3 spawnPosition = transform.position + Random.onUnitSphere*spawnRadius;
			GameObject gibInstance = Instantiate(gib,spawnPosition,gib.transform.rotation) as GameObject;
			gibInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,explosionRadius);
		}
		Destroy(gameObject);
	}
}
