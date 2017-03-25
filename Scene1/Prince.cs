using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prince : MonoBehaviour {

	GameObject prince;
	Animator anim;

	// Use this for initialization
	void Start () {
		prince = GameObject.Find("prince");
		anim = prince.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			anim.SetTrigger("next");
		}
	}
}
