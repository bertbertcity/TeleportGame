using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (speed, 0, 0);

		gameObject.transform.position += move * Time.deltaTime;

		Quaternion rotation = Quaternion.Euler (0, 0, 0);

		if (gameObject.transform.localRotation != rotation) {
			gameObject.transform.localRotation = rotation;
		}
	}
}
