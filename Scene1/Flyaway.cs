using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyaway : MonoBehaviour {

	GameObject princess,dragon;
	Animator anim,anim1;
	bool isDown = false;

	// Use this for initialization
	void Start () {
		princess = GameObject.Find("princess");
		dragon = GameObject.Find ("dragon");
		anim = princess.GetComponentInChildren<Animator>();
		anim1 = dragon.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			isDown = true;
			anim.SetTrigger("next");
			anim1.SetTrigger ("next");
		}
		if (isDown && princess.transform.localPosition.y < 10) {
			princess.transform.Translate(0,Time.deltaTime,-Time.deltaTime,Space.Self);
			dragon.transform.Translate(0,Time.deltaTime,-Time.deltaTime,Space.Self);
		}

	}
}
