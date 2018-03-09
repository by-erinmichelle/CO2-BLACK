using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAwayScript : MonoBehaviour {

	float duration = 10;

	public GameObject TapToText;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > duration) {
			Destroy (gameObject);

			TapToText.SetActive (true);

		}
	}
}
