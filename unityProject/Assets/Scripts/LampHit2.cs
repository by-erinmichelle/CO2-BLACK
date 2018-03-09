using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampHit2 : MonoBehaviour {

	//first screen (after tap to place)
	public GameObject replaceBulb;
	public GameObject badBulb;
	public GameObject cflTrans;

	//second screen (bulb was switched)
	public GameObject cflBulb;
	public GameObject BuildingFactTop;
	public GameObject pointer;

	//third screen 
	public GameObject BuildingFactBot;

	//fourth screen
	public GameObject dontForget;

	//fifth screen
	public GameObject turnOff;
	public GameObject lampSpotlight;
//	public GameObject lampSpotlight2;


	public GameObject focusSquareFocus;
	public GameObject focusSquareFind;
	public GameObject scanDots;


	public Material smokeHigh;

	//example Cube for beginning to combine scenes
	public GameObject trashCanScene;
	public GameObject newPlacedLamp;
	public GameObject nextButton;
	public GameObject newLightBulb;

	//third Module 
	public GameObject thirdModuleObj;
	public GameObject thirdButton;

	public GameObject outroBtn;

	public GameObject seeImpact;


	void Update () {
		if (replaceBulb.activeInHierarchy) {
			cflTrans.SetActive (true);
//			focusSquareFocus.SetActive (false);
//			focusSquareFind.SetActive (false);
//			scanDots.SetActive (false);

			Destroy(focusSquareFind);
			Destroy(focusSquareFocus);
			Destroy(scanDots);

			if (!scanDots.activeInHierarchy) {
				Debug.Log ("not there");
			}
			

		}
		if (cflBulb.activeInHierarchy) {
			cflTrans.SetActive (false);
		}
	}

	void HitByRay () {
		//first screen
		Debug.Log ("I was hit by a Ray");

		if (badBulb.activeInHierarchy) {
			
			BuildingFactTop.SetActive (true);
			pointer.SetActive (true);
			badBulb.SetActive (false);
			cflBulb.SetActive (true);
			replaceBulb.SetActive (false);

			smokeHigh.SetFloat ("_Alpha", 0.15f);
		}

		if (turnOff.activeInHierarchy) {
			lampSpotlight.SetActive (false);
//			lampSpotlight2.SetActive (false);

			nextButton.SetActive (true);
		}

	}

	public void nextBtn () {
		Debug.Log ("Next Button Tapped");
		//hide old text
		BuildingFactTop.SetActive (false);
		BuildingFactBot.SetActive (false);

		//hide btn and show cube
		trashCanScene.SetActive (true);
		nextButton.SetActive (false);
		newPlacedLamp.SetActive (false);
		turnOff.SetActive (false);
		newLightBulb.SetActive (false);
		thirdButton.SetActive (true);
		smokeHigh.SetFloat ("_Alpha", 0f);
		replaceBulb.SetActive (false);
		cflTrans.SetActive (false);
		pointer.SetActive (false);


		//show text
//		dontForget.SetActive (true);

//		pointer.SetActive (false);

	

		if (newPlacedLamp.activeInHierarchy) {
			Debug.Log ("didn't work");
		} else {
			Debug.Log ("Worked");
		}

	}

	public void thirdModuleBtn() {
		Debug.Log ("Third Module Button Tapped");
		trashCanScene.SetActive (false);
		thirdModuleObj.SetActive (true);


	}


	public void outro() {
		
		if (seeImpact.activeInHierarchy) {
			outroBtn.SetActive (true);

		}
			
	}
		
}
