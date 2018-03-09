using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.iOS;
using UnityEngine.EventSystems;

public class laptopHit : MonoBehaviour {

	public GameObject screen1;
	public GameObject screen2;
	public GameObject screen3;
	//public GameObject bubblePrefab;
	private static GameObject laptopSelect = null;
	private static GameObject screenTwoSelect = null;

	public GameObject nextBtn;
//	private bool secondActive = false;



	// Update is called once per frame
	void Update () {

		Debug.Log ("workin");

		int fingerCount = 0;
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;
		}

		if (fingerCount > 0)
			print("User has " + fingerCount + " finger(s) touching the screen");


		if (Input.touchCount > 0) {

			Debug.Log("touch");


			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began  && !EventSystem.current.IsPointerOverGameObject(0)) {

				Debug.Log("touch2");

				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit;

				if (Physics.Raycast (ray, out hit, 100)) {

					Debug.Log("raysent");

                    if (hit.transform.tag == "screen1"){
						Debug.Log ("plz");

						Destroy (GameObject.FindWithTag("screen1"));

					
						screen1.SetActive (false);
						screen2.SetActive (true);

                    }


					else if (hit.transform.tag == "screen2"){
						Debug.Log ("popp");

						screen2.SetActive (false);
						screen3.SetActive (true);
						nextBtn.SetActive (true);
					}
					
				}
			}
		}



	}
}
