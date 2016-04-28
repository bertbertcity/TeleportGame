using UnityEngine;
using System.Collections;
using System;

public class DeathTrigger : MonoBehaviour {

	public GameObject oldCanvas;
	public GameObject newCanvas;
	private bool active = false;
	public showScore scoreScript;
	public speedUp maxSpeed;
	public TimeUI time;
	public GameObject ethan;
	// Use this for initialization
	void Start () {
		scoreScript = FindObjectOfType<showScore> ();
		newCanvas.SetActive (false);
		maxSpeed = FindObjectOfType<speedUp> ();
		time = FindObjectOfType<TimeUI> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (active) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				time.RestartTime();
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			
			oldCanvas.SetActive (false);
			newCanvas.SetActive (true);
			active = true;
			scoreScript.distance = (float)Math.Round ((double)ethan.transform.localPosition.x, 2);
			scoreScript.time = (float)Math.Round ((double)time.time, 2);
			scoreScript.fastestSpeed = (float)Math.Round ((double)maxSpeed.fastestSpeed, 2);

		}

	}

}
