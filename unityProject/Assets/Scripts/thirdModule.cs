using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdModule : MonoBehaviour {

	public GameObject secondModuleGroup;
	public GameObject toThirdMod;
	public GameObject thirdModuleGroup;
	public GameObject thirdUI;

	public GameObject lampModel;
	public GameObject lampStand;
	public GameObject lampCFL;

	public void toThirdModBtn() {
		Debug.Log ("Go to Third Mod Button Tapped");

		//hide second module
		secondModuleGroup.SetActive (false);

		//hide btn
		toThirdMod.SetActive (false);

		//hide lamp model
		lampModel.SetActive (false);
		lampStand.SetActive (false);
		lampCFL.SetActive (false);

		//show third module
		thirdModuleGroup.SetActive (true);
		thirdUI.SetActive (true);


	}

	void Update () {
		if (thirdModuleGroup.activeInHierarchy) {
			lampModel.SetActive (false);
			lampStand.SetActive (false);
			lampCFL.SetActive (false);
		}
	}

}
