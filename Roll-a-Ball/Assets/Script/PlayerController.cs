using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {
	public float speed = 10;

	// 物理演算でキャラクターが動くたびに呼ばれる
	void FixedUpdate() {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		// このGameObjectのRigidbodyコンポーネントを取得
		Rigidbody rb = GetComponent<Rigidbody>();

		rb.AddForce(x * speed, 0, z * speed);
	}
}
