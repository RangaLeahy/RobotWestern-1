using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour 
{
	public float moveSpeed = 1.0f;
	
	// Update is called once per frame
	void Update () 
	{
		//wasd
		Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0);
		transform.position += moveDirection*moveSpeed*Time.deltaTime;
	}
}
