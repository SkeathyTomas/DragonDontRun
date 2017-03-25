using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class GetSpring : MonoBehaviour {

	GameObject prince1;
	Animator animb;
	int walk = 0;
	int state = 0;
	int right = 1;
	bool isTip = false;
	bool isGet = false;
	SerialPort stream = new SerialPort("COM6",9600);
	string s;

	// Use this for initialization
	void Start () {
		prince1 = GameObject.Find ("prince1");
		animb = prince1.GetComponentInChildren<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		ArduinoSignal ();

		//按一下A，蝴蝶提醒完成，开始走动，按两下A，state=2,获得泉水，停止走动
		if (Input.GetKeyDown (KeyCode.A)) {
			animb.SetTrigger ("next");
			isTip = true;
			state++;
		}
		if (isTip && walk < 50 && !isGet) {
			prince1.transform.Translate (Time.deltaTime*right,0,0,Space.World);
			walk++;
		}

		if (walk == 50) {
			prince1.transform.Rotate (new Vector3 (0, 1, 0), 180);
			walk = 0;
			right = -right;
		}

		if (state == 2 || s == "turn") {
			isGet = true;
			animb.SetTrigger ("next");
		}
	}

	void ArduinoSignal(){
		stream.Open();
		s = stream.ReadLine(); // value from Arduino
		stream.Close();
		Debug.Log(s);
	}
}
