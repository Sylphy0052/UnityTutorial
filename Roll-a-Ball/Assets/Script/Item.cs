using UnityEngine;
using System.Collections;

public class Item: MonoBehaviour {
	// トリガーと接触した時に呼ばれるコールバック関数
	void OnTriggerEnter(Collider hit) {
		if(hit.CompareTag("Player")) {
			// delete this Object
			Destroy(gameObject);
		}
	}
}
