using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chop : MonoBehaviour {

	GameObject sword2;
	bool isChop = false;
	int angle = 0;

	// Use this for initialization
	void Start () {
		sword2 = GameObject.Find ("sword2");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			isChop = true;
		}
		if (isChop && angle < 90) {
			sword2.transform.Rotate (new Vector3(0,0,1),18);
			angle += 18;
		}
	}
}
