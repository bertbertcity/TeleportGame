using UnityEngine;
using System.Collections;


public class replace : MonoBehaviour {

	public GameObject newPlat;

	// Use this for initialization
	void Start () {
		GameObject[] platforms = GameObject.FindGameObjectsWithTag ("platforms");

		foreach (GameObject platform in platforms) {
	
			GameObject newPlatTemp = (GameObject) Instantiate (newPlat,platform.transform.position,Quaternion.identity);
			newPlatTemp.transform.localScale = platform.transform.localScale;
			newPlatTemp.transform.SetParent (platform.transform.parent);
			Destroy (platform);
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
