using UnityEngine;
using System.Collections;

public class speedUp : MonoBehaviour {

	public GameObject player;
	public GameObject teleporter;
	public float speedMultiplyer = 1;
	public bool initiateSpeed = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (initiateSpeed)
		StartCoroutine (initiate ());

	}
	int timesSpedUp = 0;
	IEnumerator initiate() {
		
		initiateSpeed = false;
		yield return new WaitForSeconds(5);

		float time = 0f;
		float totalTime = 5f;
		float tempPlayer = player.GetComponent<PlayerMovement> ().speed;
		float tempTele = teleporter.GetComponent<Teleport> ().speed;
		float initSpeed = speedMultiplyer;
		float targetSpeed = speedMultiplyer + .3f;

		while (time < totalTime) {
			
			speedMultiplyer = Mathf.Lerp (initSpeed, targetSpeed, time / totalTime);

			yield return null;

			time += Time.deltaTime;

			player.GetComponent<PlayerMovement> ().speed = tempPlayer * speedMultiplyer;
			teleporter.GetComponent<Teleport> ().speed = tempTele * speedMultiplyer;

		}
		timesSpedUp++;
		yield return null;
		initiateSpeed = true;
		Debug.Log (timesSpedUp);
	}
		
}
