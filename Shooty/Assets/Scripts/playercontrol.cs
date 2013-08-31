using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour 
{
	public float moveSpeed = 1.0f;
	
	public GameObject bullet;
	public float bulletSpeed = 1.0f;
	public float shootDelay = 0.2f;
	
	public bool canShoot = true;
	
	
	// Update is called once per frame
	void Update () 
	{
		//wasd
		Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0);
		transform.position += moveDirection*moveSpeed*Time.deltaTime;
		
		//shootyshoot
		if((Input.GetAxis("FireHorizontal") != 0.0f || Input.GetAxis("FireVertical") != 0.0f) && canShoot)
		{
			Vector3 shootDirection = new Vector3(Input.GetAxis("FireHorizontal"),Input.GetAxis("FireVertical"), 0).normalized;
			GameObject bulletInstance = Instantiate(bullet,transform.position,Quaternion.LookRotation(shootDirection)) as GameObject;
			bulletInstance.rigidbody.AddForce(shootDirection*bulletSpeed,ForceMode.VelocityChange);
			canShoot = false;
			Invoke("ShootDelay", shootDelay);
		}
			
	}
	
	void ShootDelay()
	{
		canShoot = true;	
	}
}
