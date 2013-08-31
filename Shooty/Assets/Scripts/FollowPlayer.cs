using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour 
{
	public float speed = 1.0f;
	
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 moveDirection = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position).normalized;
		transform.position += moveDirection*speed*Time.deltaTime;
	}
}
