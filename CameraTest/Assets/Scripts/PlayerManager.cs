using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
	private GameObject MainCamera;

	// Use this for initialization
	void Start () {
		MainCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		this.transform.rotation = MainCamera.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = MainCamera.transform.rotation;
	}
}
