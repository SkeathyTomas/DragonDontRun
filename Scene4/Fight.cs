using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {

	GameObject prince3;
	Animator anim;

	// Use this for initialization
	void Start () {
		prince3 = GameObject.Find ("prince3");
		anim = prince3.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetTrigger ("next");
		}
	}
}
