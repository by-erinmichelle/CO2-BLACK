using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour {

	public GameObject badLight;

	public float timeOn = 0.1f;
	private float timeOff = 0.5f;
	private float changeTime = 0;
	public Light lit;


	void Update() {
		if (Time.time > changeTime) {
			lit.enabled = !lit.enabled;
			if (lit.enabled) {
				changeTime = Time.time + timeOn;
			} else {
				changeTime = Time.time + timeOff;
			}
		}
	}
}
