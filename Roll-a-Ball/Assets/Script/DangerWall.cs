using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall: MonoBehaviour {
	void OnCollisionEnter(Collision hit) {
		// when this collide player
		if(hit.gameObject.CompareTag("Player")) {
			// get scene index
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;
			// Scene reload
			SceneManager.LoadScene(sceneIndex);
		}
	}
}
