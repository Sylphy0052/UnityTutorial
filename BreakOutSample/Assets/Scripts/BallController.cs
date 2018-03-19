using UnityEngine;

public class BallController : MonoBehaviour {
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		var force = (transform.forward + transform.right) * speed;
		GetComponent<Rigidbody> ().AddForce (force, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
