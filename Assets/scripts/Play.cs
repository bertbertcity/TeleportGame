using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
		}

		public void NextLevel(){
			Application.LoadLevel ("level");
			//Debug.Log("Next scene");
		}
	}
