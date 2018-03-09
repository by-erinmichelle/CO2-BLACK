using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyHit : MonoBehaviour {

	//first screen 
	public GameObject coal;
	public GameObject solar;
	public GameObject chooseEnergy;

	//second screen 
	public GameObject energyFact;
	public GameObject pointer;

	public GameObject energyFact2;

	public GameObject seeImpact;


	public Material smokeHigh;

	public void chosenEnergy() {

		coal.SetActive (false);
		chooseEnergy.SetActive (false);
		pointer.SetActive (true);
		energyFact.SetActive (true);

		smokeHigh.SetFloat ("_Alpha", 0.15f);

	}

	public void energyFactbtn() {
		energyFact2.SetActive (true);
		energyFact.SetActive (false);
	}

	public void energyFact2btn() {
		energyFact2.SetActive (false);
		seeImpact.SetActive (true);
	}

}
