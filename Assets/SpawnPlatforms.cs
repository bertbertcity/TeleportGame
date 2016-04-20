using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

	public GameObject[] platformModules;
	public int maxModules = 5;
	private Vector3 startPosition;
	public GameObject end;
	private GameObject currModule;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			if (currModule) {
				Destroy (currModule);
			}
			Spawn ();
		}


	}

	void Spawn() {
		//int moduleIndex = Random.Range (0, 2);
		Debug.Log("Spawning");
		int moduleIndex = 0;
		GameObject module = platformModules[moduleIndex];
		startPosition = new Vector3 (end.transform.position.x, 0, 0);
		currModule = (GameObject)Instantiate(module, startPosition, Quaternion.identity);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
