using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstModule : MonoBehaviour {

	//first screen (after tap to place)
	public GameObject buildingFact;
	public GameObject buildingFact_trans;
	public GameObject badBulb;
	public GameObject cflTrans;

	//second screen 
	public GameObject cflBulb;
	public GameObject lampShade;
	public Material lampShadeMat;
	public GameObject replaceBulb;
	public GameObject pointer;

	//third screen 
	public GameObject dontForget;
	public GameObject dontForgetTrans;

	//fourth screen
	public GameObject turnOff;
	public GameObject lampSpotlight;

	public GameObject learningLayerLamp;


//	public GameObject lampContainer;
//	public GameObject BlueFocusSquare;
//	public GameObject FocusedSquare;
//	public ParticleSystem scanningDots;
//	public GameObject scanningDotsPs;
//	public GameObject scanningDots;

	//to second module
	public GameObject toSecondMod;

	void Update () {
//		if (buildingFact.activeInHierarchy) {
////	foundSquare.SetActive (squareState != FocusState.Found);
////	findingSquare.SetActive (squareState != FocusState.Found);
//		//Destroy (FocusedSquare);
//		//BlueFocusSquare.SetActive (false);
//		//Destroy (BlueFocusSquare);
////	scanningDots.GetComponent<ParticleSystem>().enableEmission = false;
////	scanningDots.Stop();
//		scanningDotsPs.SetActive (false);
//		//Destroy (scanningDots);
//	}
		//if text says "tap to replace bulb" show the cfl sprite
		if (replaceBulb.activeInHierarchy) {
			cflTrans.SetActive (true);
		}
		//if bulb has been switched, hide the cfl sprite
		if (cflBulb.activeInHierarchy) {
			cflTrans.SetActive (false);
			replaceBulb.SetActive (false);
			lampShade.SetActive (true);
		}
		if (cflBulb.activeInHierarchy && !turnOff.activeInHierarchy || !learningLayerLamp.activeInHierarchy) {
			dontForgetTrans.SetActive (true);
			dontForget.SetActive (true);
		}

	}

	void HitByRay () {
		Debug.Log ("I was hit by a Ray");
		if (replaceBulb.activeInHierarchy) {

			badBulb.SetActive (false);

			cflBulb.SetActive (true);

			lampShade.GetComponent<Animation>().Play();
			pointer.SetActive (true);
		
		}

		if (turnOff.activeInHierarchy) {
			lampSpotlight.SetActive (false);
			lampShade.SetActive (true);
			lampShadeMat.DisableKeyword ("_EMISSION");
			toSecondMod.SetActive (true);
			turnOff.SetActive (false);
			Destroy(dontForgetTrans);
			Destroy(dontForget);
		}

	}


}
