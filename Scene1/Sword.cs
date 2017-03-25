using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	int state = 0;
	GameObject sword;
	Vector3 orin;
	Vector3 FAR_AWAY = new Vector3(1000,1000,1000);

	// Use this for initialization
	void Start () {
		sword = GameObject.Find ("sword");
		orin = sword.transform.position;
		sword.transform.position = FAR_AWAY;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			state++;
		}
		if (state >= 5) {
			sword.transform.position = orin;
		}
	}
}