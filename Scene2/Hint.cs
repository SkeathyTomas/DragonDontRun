using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Hint : MonoBehaviour {
	
	GameObject text;
	Vector3 FAR = new Vector3(1000,1000,1000);
	Vector3 orin;
	int state = 0;
	SerialPort stream = new SerialPort("COM6",9600);
	string s;

	// Use this for initialization
	void Start () {
		text = GameObject.Find ("hint");
		orin = text.transform.position;
		text.transform.position = FAR;
	}
	
	// Update is called once per frame
	void Update () {

		ArduinoSignal ();

		if (Input.GetKeyDown (KeyCode.A) && state < 2) {
			text.transform.position = orin;
			state++;
		}
		if (state == 2 || s == "turn") {
			text.transform.position = FAR;
		}
	}

	void ArduinoSignal(){
		stream.Open();
		s = stream.ReadLine(); // value from Arduino
		stream.Close();
		Debug.Log(s);
	}
}
