using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {
	private bool startFlg;
	private bool fixFlg; //スタートする前の物体固定フラグ
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		startFlg = true;
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (startFlg) {
//			Debug.Log ("Ready");
//			if (Input.GetTouch (0).phase == TouchPhase.Ended) {
			if(Input.GetMouseButtonUp(0)) {
				Debug.Log ("Start");
				startFlg = false;
				Quaternion directionQuaternion = transform.rotation;
				Vector3 directionVector = directionQuaternion.eulerAngles;
				rigidbody.AddForce (directionVector * 500.0f, ForceMode.Force);
			}
			// 位置の変更
//			this.gameObject.transform.position = ;
		}
		// Y座標を固定したい
		Vector3 currentPos = transform.position;
		transform.position = new Vector3(currentPos.x, 0.5f, currentPos.z);
	}

	void OnCollisionEnter(Collision coll) {
		if(coll.gameObject.CompareTag("wall")) {
			rigidbody.AddForce ((transform.forward + transform.right) * 10.0f, ForceMode.Force);
		}

		if(coll.gameObject.CompareTag("Player")) {
			Destroy(this);
		}

		if(coll.gameObject.CompareTag("block")) {
			Destroy (coll.gameObject);
		}
		if(coll.gameObject.CompareTag("bar")) {
			rigidbody.AddForce ((transform.forward + transform.right) * 10.0f, ForceMode.Force);
		}
	}

//	void OnCollisionExit(Collision coll) {
//		
//	}

	void OnTriggerEnter(Collider coll) {
		
	}
}
