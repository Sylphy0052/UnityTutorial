using System.Collections;
using UnityEngine;

public class GameController: MonoBehaviour {
	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;
	private int count = 0;

	public void Update() {
		count = GameObject.FindGameObjectsWithTag("Item").Length;
		scoreLabel.text = count.ToString();

		if(count == 0) {
			winnerLabelObject.SetActive(true);
		}
	}
}
