using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class SwordAppear : MonoBehaviour {

	GameObject sword1;
	int y;
	bool appear = false;
	SerialPort stream = new SerialPort("COM6",9600);
	string s;

	// Use this for initialization
	void Start () {
		sword1 = GameObject.Find ("sword1");
	}
	
	// Update is called once per frame
	void Update () {
		ArduinoSignal ();

		if (Input.GetKeyDown (KeyCode.S) || s == "empty") {
			appear = true;
		}
		if (appear && y < 20) {
			sword1.transform.Translate (0, Time.deltaTime, 0, Space.World);
			y++;
		}
	}

	void ArduinoSignal(){
		stream.Open();
		s = stream.ReadLine(); // value from Arduino
		stream.Close();
		Debug.Log(s);
	}
}
