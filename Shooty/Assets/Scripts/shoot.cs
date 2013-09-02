using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public Vector3 mouseDirection = Vector3.forward; //Temporary direction in place of mouse input.
	
	public GameObject bullet;
	public float bulletSpeed = 1.0f;
	public float mode1Frequency = 5.0f; //In bullets per second.
	public float mode3Frequency = .666f;
	
	public int shootMode = 1;
	public bool canShoot = true;
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("1")) {
			shootMode = 1;
		} else if (Input.GetKeyDown("2")) {
			shootMode = 2;
		} else if (Input.GetKeyDown ("3")) {
			shootMode = 3;
		}//Sets the shoot mode.
		
		if (shootMode == 1) {
			if (Input.GetKey("mouse 0") && canShoot) {
				shoot(mouseDirection);
				canShoot = false;
				Invoke("shootDelay",(1/mode1Frequency));
			}
		} else if (shootMode == 2) {
			if (Input.GetKeyDown ("mouse 0") && canShoot) {
				shoot(mouseDirection);
			}
		} else if (shootMode == 3) {
			if (Input.GetKeyDown ("mouse 0") && canShoot) {
				shoot (Vector3.back);
				shoot (Vector3.forward);
				shoot (Vector3.left);
				shoot (Vector3.right);
				canShoot = false;
				Invoke ("shootDelay",(1/mode3Frequency));
			}
		}
	}
	
	void shoot(Vector3 shootDirection) {//Shoots a bullet in the shootDirection
		GameObject bulletInstance = Instantiate(bullet,transform.position,Quaternion.LookRotation(shootDirection)) as GameObject;
		bulletInstance.rigidbody.AddForce(shootDirection*bulletSpeed,ForceMode.VelocityChange);
	}
		
	void shootDelay() {
		canShoot = true;
	}
	
	float convertToAngle(Vector3 vectorThree){
		var angle = Vector3.Angle(Vector3.forward, vectorThree);
		return angle;
	}
	
}