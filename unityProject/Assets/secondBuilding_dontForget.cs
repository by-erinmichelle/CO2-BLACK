using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondBuilding_dontForget : MonoBehaviour {


	public GameObject BuildingFactBot_Trans;
	public GameObject BuildingFactBot;
	public GameObject dontForget;
	public GameObject dontForgetTrans;

	public void BuildingFactBotBtn () {

		BuildingFactBot.SetActive (false);
		BuildingFactBot_Trans.SetActive (false);
		dontForgetTrans.SetActive (true);
		dontForget.SetActive (true);
	}
}
