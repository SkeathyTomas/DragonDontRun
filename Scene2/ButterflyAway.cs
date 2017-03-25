using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyAway : MonoBehaviour {

	GameObject butterfly;

	// Use this for initialization
	void Start () {
		butterfly = GameObject.Find ("butterfly");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			butterfly.SetActive (false);
		}
	}
}
