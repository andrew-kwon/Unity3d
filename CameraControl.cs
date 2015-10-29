using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	
	Vector3 rotationRate;
	Vector3 angle;
	Vector3 startAngle;
	// Vector3 startDualAngle;
	public GameObject camera;
	//  public GameObject dualCamera;
	float ROTATION_SPEED = 0.1f;
	float startAngleX, startAngleY,startAngleZ;
	void Start()
	{
		Input.gyro.enabled = true;
		startAngle = camera.transform.localEulerAngles;
		//   startDualAngle = dualCamera.transform.localEulerAngles;
		
	}
	void Update()
	{
		
		if ((Mathf.Abs(Input.gyro.rotationRateUnbiased.y) > ROTATION_SPEED) )
		{
			rotationRate = Input.gyro.rotationRateUnbiased;
			angle.y += -rotationRate.y * 3;
			angle.z = 0;
			camera.transform.localEulerAngles = angle;
			// dualCamera.transform.localEulerAngles = angle;
			
			
		}
		if ((Mathf.Abs(Input.gyro.rotationRateUnbiased.x) > ROTATION_SPEED))
		{
			rotationRate = Input.gyro.rotationRateUnbiased;
			angle.x += -rotationRate.x * 3;
			angle.z = 0;
			camera.transform.localEulerAngles = angle;
			// dualCamera.transform.localEulerAngles = angle;
			
		}
		if (Input.GetButtonDown("StartPoint"))
		{
			camera.transform.localEulerAngles = startAngle;
			// dualCamera.transform.localEulerAngles = startDualAngle;
			angle.x =startAngle.x;
			angle.y =startAngle.y;
		}
		
	}
	void OnGUI()
	{
		GUILayout.TextArea("rotation y : " + Input.gyro.rotationRateUnbiased.y + "\nrotation x : " + Input.gyro.rotationRateUnbiased.x+"\nrotaion z: "+Input.gyro.rotationRateUnbiased.z);
		GUILayout.TextArea("rotation x : " +Input.gyro.userAcceleration.x);
		
	}
}

