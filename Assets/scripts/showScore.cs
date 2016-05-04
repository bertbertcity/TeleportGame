using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showScore : MonoBehaviour {

	public float distance;
	public float fastestSpeed;
	public float time;
	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		text.text = "Distance = " + distance + "m\nFastest Speed = " + fastestSpeed + "\n Time = " + time + "s\n Score = " + calculateScore (distance, fastestSpeed, time) + "\nPress 'space' to restart!"; 
	}

	// revisions fosho
	public int calculateScore(float d, float s, float t) {
		return (int)(((10 * d) + (100 * t)) * s);
	}
}
