using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampHit : MonoBehaviour {

	public GameObject lampSpotlight;
	public GameObject lampSpotlight2;
	public Material lampShade;
	public GameObject BuildingFactTop;
	public GameObject BuildingFactBot;
	public Material smokeHigh;
//	public GameObject impactButton;

	//first half
	public GameObject nextButton;
	public GameObject cflBulb;
	public GameObject badBulb;
	public GameObject replaceBulb;
	public GameObject cflTrans;
	public GameObject pointer;

	//second half
	public GameObject dontForget;
	public GameObject turnOff;


	//example Cube for beginning to combine scenes
	public GameObject exampleCube;
	public GameObject newPlacedLamp;


//	public GameObject smokeHigh;
//
//	public Material smokeLow;

	void Update () {
		if (replaceBulb.activeInHierarchy) {
			cflTrans.SetActive (true);
		}
		if (cflBulb.activeInHierarchy) {
			cflTrans.SetActive (false);
		}

	}

	void HitByRay () {
		//first screen
		Debug.Log ("I was hit by a Ray");

		if (badBulb.activeInHierarchy) {
//		lampShade.DisableKeyword ("_EMISSION");
//		lampSpotlight.SetActive (false);

			BuildingFactTop.SetActive (true);
			pointer.SetActive (true);
			BuildingFactBot.SetActive (true);
			badBulb.SetActive (false);
			cflBulb.SetActive (true);
			nextButton.SetActive (true);
			replaceBulb.SetActive (false);

//		MeshRenderer smokeHighMesh = smokeHigh.GetComponent<MeshRenderer>();
//
//		smokeLow = smokeHighMesh.material; 

			smokeHigh.SetFloat ("_Alpha", 0.15f);
		}

		if (dontForget.activeInHierarchy) {
			lampSpotlight.SetActive (false);
		}
	}

	public void nextBtn () {
		Debug.Log ("Next Button Tapped");
		//hide old text
		BuildingFactTop.SetActive (false);
		BuildingFactBot.SetActive (false);

		//show text
		dontForget.SetActive (true);
		turnOff.SetActive (true);
		pointer.SetActive (false);

		//hide btn
		nextButton.SetActive (false);

		newPlacedLamp.SetActive (false);
		if (newPlacedLamp.activeInHierarchy) {
			Debug.Log ("didn't work");
		} else {
			Debug.Log ("Worked");
		}

		exampleCube.SetActive (true);

	}
}
