using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour
{
	public float speed = 5.0f;        // moving speed
	public float rotSpeed = 120.0f; // rotation speed
	public GameObject turret;       // tank turret object
	public bool test;
	
	public int power = 2000;  // bullet speed power
	public Transform bullet;  // bullet object
	void Update()
	{
		float amtToMove = speed * Time.deltaTime;  // moving distance per frame
		float amtToRot = rotSpeed * Time.deltaTime;  // rotation angle per frame
		
		float front = Input.GetAxis("Vertical");          // get input information (moving front/back)
		float ang = Input.GetAxis("Horizontal");       // get input information (moving left/right)
		
		transform.Translate(Vector3.forward * front * amtToMove); // moving front/back
		transform.Rotate(new Vector3(0, ang * amtToRot, 0));        // moving left/right
		
		
	}
}

