using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		//anim.SetFloat("Speed", 1);
	}

	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (speed, 0, 0);

		gameObject.transform.position += move * Time.deltaTime;
		Vector3 targetDirection = new Vector3 (1, 0, 0);
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
		GetComponent<Rigidbody> ().MoveRotation (targetRotation);
//		Quaternion rotation = Quaternion.Euler (0, 0, 0);
//
//		if (gameObject.transform.localRotation != rotation) {
//			gameObject.transform.localRotation = rotation;
//		}
	}
}
