using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
		// Use this for initialization
	public string newlevel = "EliseModule";
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void NextLevel(){
		Application.LoadLevel ("EliseModule");
		Debug.Log("Next scene");
	}
}
