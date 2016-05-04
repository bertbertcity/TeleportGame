using UnityEngine;
using System.Collections;

public class destroyObs : MonoBehaviour {

	public GameObject firee;
	public destroyFire firebolt;

	// Use this for initialization
	void Start () {
		firebolt = FindObjectOfType<destroyFire> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag("destroy")) {

			Instantiate (firee, col.transform.position, col.transform.rotation);
			firebolt.die = true;
			Destroy(col.gameObject);
			Debug.Log ("what is going on");
		}
			
	}


}
