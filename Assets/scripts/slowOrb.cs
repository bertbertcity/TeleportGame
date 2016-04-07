using UnityEngine;
using System.Collections;

public class slowOrb : MonoBehaviour {

	//public GameObject player;
	public speedUp speed;

	// Use this for initialization
	void Start () {
		speed = FindObjectOfType<speedUp> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			Debug.Log ("collide");
			speed.slowDown = true;
			speed.initiateSlowDown = true;
			Destroy (gameObject);
		}
	}
}
