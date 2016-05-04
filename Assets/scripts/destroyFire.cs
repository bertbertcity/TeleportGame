using UnityEngine;
using System.Collections;

public class destroyFire : MonoBehaviour {

	public bool die = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (die) {
			Destroy (gameObject);
		}
	}
}
