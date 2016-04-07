using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class TimeUI : MonoBehaviour {

	public Text t;
	private string temp;
	public float time;

	// Use this for initialization
	void Start () {
		t = GetComponent<Text> ();
		temp = t.text;

	}

	// Update is called once per frame
	void Update () {

		time = (float)Math.Round ((double)Time.time, 2);

		t.text = temp + time;
	}
}

