using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeated : MonoBehaviour {

	GameObject dragon1;
	int time = 0;

	// Use this for initialization
	void Start () {
		dragon1 = GameObject.Find ("dragon1");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			time++;
		}
		if (time >= 1) {
			time++;
		}
		if (time == 10) {
			dragon1.transform.position = new Vector3 (1000, 1000, 1000);
		}
	}
}
