using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstBuilding_secondBuilding : MonoBehaviour {


	public GameObject BuildingFactTop;
	public GameObject BuildingFactTop_Trans;
	public GameObject BuildingFactBot_Trans;
	public GameObject BuildingFactBot;


	public void BuildingFactTopBtn () {

		BuildingFactTop.SetActive (false);
		BuildingFactTop_Trans.SetActive (false);
		BuildingFactBot_Trans.SetActive (true);
		BuildingFactBot.SetActive (true);
	}
}
