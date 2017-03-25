using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class GetSword : MonoBehaviour {

	GameObject prince2;
	Animator anim;
	int delay = 0;
	SerialPort stream = new SerialPort("COM6",9600);
	string s;

	// Use this for initialization
	void Start () {
		prince2 = GameObject.Find ("prince2");
		anim = prince2.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		ArduinoSignal ();

		if (Input.GetKeyDown (KeyCode.S) || s == "empty") {
			delay++;
		}

		if (delay >= 1 && delay < 25) {
			delay++;
		}

		if (delay == 25) {
			anim.SetTrigger ("next");
		}
	}

	void ArduinoSignal(){
		stream.Open();
		s = stream.ReadLine(); // value from Arduino
		stream.Close();
		Debug.Log(s);
	}
}
