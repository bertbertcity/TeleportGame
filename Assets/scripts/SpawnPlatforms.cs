using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {
	public GameObject end;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			Spawn ();
		}


	}

	void Spawn() {
		GameObject platforms = GameObject.FindGameObjectWithTag ("platforms");
		GameObject module = platforms.GetComponent<GetPlatforms> ().GetRandomPlatform ();
		Vector3 startPosition = new Vector3 (end.transform.position.x, 0, 0);
		Instantiate(module, startPosition, Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
