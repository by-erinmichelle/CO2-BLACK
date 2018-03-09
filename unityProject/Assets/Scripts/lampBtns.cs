using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampBtns : MonoBehaviour {

	public GameObject BuildingFactTop;
	public GameObject BuildingFactTop_Trans;
	public GameObject BuildingFactBot_Trans;
	public GameObject BuildingFactBot;
	public GameObject dontForget;
	public GameObject dontForgetTrans;
	public GameObject turnOff;
	public GameObject turnOffTrans;
	public GameObject pointer;


	public void BuildingFactTopBtn () {

		BuildingFactTop.SetActive (false);
		BuildingFactTop_Trans.SetActive (false);
		BuildingFactBot_Trans.SetActive (true);
		BuildingFactBot.SetActive (true);
	}

	public void BuildingFactBotBtn () {

		BuildingFactBot.SetActive (false);
		BuildingFactBot_Trans.SetActive (false);
		dontForgetTrans.SetActive (true);
		dontForget.SetActive (true);
	}

	public void dontForgetBtn () {
		dontForgetTrans.SetActive (false);
		dontForget.SetActive (false);
		pointer.SetActive (false);
		turnOffTrans.SetActive (true);
		turnOff.SetActive (true);
	}

}
