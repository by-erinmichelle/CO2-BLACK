using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;
using UnityEngine.EventSystems;

public class thirdmod : MonoBehaviour {

	public GameObject fire;
	public GameObject fireDefault;
	public GameObject coal;
	public GameObject gas;
	public GameObject clean;

	public GameObject woodEnergy;
	public GameObject coalEnergy;
	public GameObject gasEnergy;
	public GameObject allEnergy;

	public GameObject getClean;
	public bool cleanEnergy = true;


	public GameObject laptopFirstStep;
	public GameObject laptop;
	public GameObject table;
	public GameObject screen1;
	public GameObject screen2;
	public GameObject screen3;

//	show coal model
	public void turnOnCoal() {
		coal.SetActive (true);
		coalEnergy.SetActive (true);
		woodEnergy.SetActive (false);
	}

//	show gas model
	public void turnOnGas(){
		gas.SetActive (true);
		gasEnergy.SetActive (true);
		coalEnergy.SetActive (false);
	}

//	show clean models
	public void turnOnAll(){
		clean.SetActive (true);
		allEnergy.SetActive (true);
		gasEnergy.SetActive (false);
	}

//	show "its simple" text
	public void turnOnCleanText() {
		allEnergy.SetActive (false);
		getClean.SetActive (true);


	}
//	void OnCollisionEnter(Collision collision) {	
//		if (collision.gameObject.name == "fire" || collision.gameObject.name == "coal" || collision.gameObject.name == "gas") {
//
//			fireDefault.GetComponent<Animation> ().Play ();
//			StartCoroutine (negativeCoroutine ());
//
//		}
//	}

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

					if (hit.transform.tag == "fire"){
						Debug.Log ("plz");

						Handheld.Vibrate();

//						fireDefault.GetComponent<Animation> ().Play ();



					}
						

				}
			}
		}



	}


//	hide all the models, show laptop first screen ui
	public void hideAllModels() {
		getClean.SetActive (false);
		fire.SetActive (false);
		coal.SetActive (false);
		gas.SetActive (false);
		clean.SetActive (false);
		laptop.SetActive (true);
		table.SetActive (true);
		screen1.SetActive (true);
		Debug.Log("boiiiii");
	}




}
