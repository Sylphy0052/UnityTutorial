using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
	private Quaternion firstCameraQuaternion;

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		firstCameraQuaternion = this.transform.rotation;
//		Quaternion gyroFirst = Input.gyro.attitude;
//		firstCameraQuaternion = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyroFirst.x, -gyroFirst.y, gyroFirst.z, gyroFirst.w));
//		Debug.Log (firstCameraQuaternion);
	}

	// Update is called once per frame
	void Update () {
		RotateByKey();
//		RotateByGyro();
	}

	void RotateByKey() {
		if(Input.GetKey(KeyCode.A)) {
			this.transform.Rotate(0,-100 * Time.deltaTime,0);
		}
		if(Input.GetKey(KeyCode.D)) {
			this.transform.Rotate(0,100 * Time.deltaTime,0);
		}
	}

	void RotateByGyro() {
		Quaternion gyro = Input.gyro.attitude;
		Quaternion gyroQuaternion = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w));
//		Debug.Log (gyroQuaternion);
//		Vector3 gyroVector3 = gyroQuaternion.eulerAngles;
//		Debug.Log (gyroVector3);
//		this.transform.Rotate (0, gyroVector3.y, 0);
//		this.transform.rotation = gyroQuaternion;
		// Xが縦(上下)->不必要
		// Yが横(これが必要)これだけだと180度しかいかない
		// Zが…?
		// Wが…
//		this.transform.rotation = new Quaternion(firstCameraQuaternion.x, gyroQuaternion.y, firstCameraQuaternion.z, firstCameraQuaternion.w);
		this.transform.rotation = new Quaternion(firstCameraQuaternion.x, gyroQuaternion.y, firstCameraQuaternion.z, gyroQuaternion.w);
	}
}
