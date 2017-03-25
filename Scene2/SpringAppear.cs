using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SpringAppear : MonoBehaviour {

	GameObject spring1;
	Vector3 FAR = new Vector3(1000,1000,1000);
	Vector3 orin;
	int state = 0;
	SerialPort stream = new SerialPort("COM6",9600);
	string s;

	// Use this for initialization
	void Start () {
		spring1 = GameObject.Find ("spring1");
		orin = spring1.transform.position;
		spring1.transform.position = FAR;
	}
	
	// Update is called once per frame
	void Update () {

		ArduinoSignal ();

		if (Input.GetKeyDown (KeyCode.A)) {
			state++;
		}

		if (state == 2 || s == "turn") {
			spring1.transform.position = orin;
		}
	}

	void ArduinoSignal(){
		stream.Open();
		s = stream.ReadLine(); // value from Arduino
		stream.Close();
		Debug.Log(s);
	}

}
