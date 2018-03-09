﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.iOS;

public class Move : MonoBehaviour {

	//public GameObject bubblePrefab;
	private static GameObject objectSelect = null;


	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) {
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit;

				if (Physics.Raycast (ray, out hit, 100)) {
					if(gameObject.tag == "goodTrash" || gameObject.tag == "badTrash"){
						objectSelect = hit.transform.gameObject;
					}
				}
			}

			Debug.Log ("Touch Position" + touch.position);
			if (touch.phase == TouchPhase.Moved) {
				Vector3 fingerPosition = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, 1f));
				objectSelect.transform.position = new Vector3(fingerPosition.x, fingerPosition.y, fingerPosition.z);
			}
		}
	}
}
