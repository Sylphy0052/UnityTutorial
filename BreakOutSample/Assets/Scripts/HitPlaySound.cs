using UnityEngine;

public class HitPlaySound : MonoBehaviour {

	public AudioClip sound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		AudioSource.PlayClipAtPoint (sound, transform.position);
	}
}
