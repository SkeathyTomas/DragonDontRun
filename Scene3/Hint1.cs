using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Hint1 : MonoBehaviour {

	GameObject hint1;
	SerialPort stream = new SerialPort("COM6",9600);
	string s;

	// Use this for initialization
	void Start () {
		hint1 = GameObject.Find ("hint1");
	}
	
	// Update is called once per frame
	void Update () {
		ArduinoSignal ();

		if (Input.GetKeyDown (KeyCode.S) || s == "empty") {
			hint1.transform.position = new Vector3 (1000, 1000, 1000);
		}
	}

	void ArduinoSignal(){
		stream.Open();
		s = stream.ReadLine(); // value from Arduino
		stream.Close();
		Debug.Log(s);
	}
}
