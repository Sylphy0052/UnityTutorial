using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}

	// Update is called once per frame
	void Update () {
//		RotateByKey();
		RotateByGyro();
	}

	void RotateByKey() {
		if(Input.GetKey(KeyCode.A)) {
			this.transform.Rotate(0,-50 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.D)) {
			this.transform.Rotate(0,50 * Time.deltaTime,0);
		}
	}

	void RotateByGyro() {
		Quaternion gyro = Input.gyro.attitude;
		this.transform.localRotation = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w));
	}
}
