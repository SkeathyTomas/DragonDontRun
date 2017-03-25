using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour {

	int state = 0;
	GameObject spring;
	Vector3 orin;
	Vector3 FAR_AWAY = new Vector3(1000,1000,1000);

	// Use this for initialization
	void Start () {
		spring = GameObject.Find ("spring");
		orin = spring.transform.position;
		spring.transform.position = FAR_AWAY;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			state++;
		}
		if (state >= 4) {
			spring.transform.position = orin;
		}
	}
}
