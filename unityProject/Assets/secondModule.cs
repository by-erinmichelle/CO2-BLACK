using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondModule : MonoBehaviour {

	public GameObject firstModuleGroup;
	public GameObject lampModel;
	public GameObject lampStand;
	public GameObject lampCFL;
	public GameObject lampShade;

	public GameObject secondInstructions;

	//to second module
	public GameObject toSecondMod;

	public GameObject secondModuleGroup;

	public GameObject toThirdMod;


	public void toSecondModBtn () {
		Debug.Log ("Go to Second Mod Button Tapped");

		//hide the first module
		firstModuleGroup.SetActive (false);
		lampModel.SetActive (false);
		lampStand.SetActive (false);
		lampCFL.SetActive (false);
		lampShade.SetActive (false);

		//hide btn
		toSecondMod.SetActive (false);

		//show second module
		secondModuleGroup.SetActive (true);
		secondInstructions.SetActive (true);

		//for now
		toThirdMod.SetActive (true);


		if (firstModuleGroup.activeInHierarchy) {
			Debug.Log ("didn't work");
		} else {
			Debug.Log ("Worked");
		}

	}

	void Update () {
		if (secondModuleGroup.activeInHierarchy) {
			lampModel.SetActive (false);
			lampStand.SetActive (false);
			lampCFL.SetActive (false);
			lampShade.SetActive (false);
		}
	}
}
