using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outroController : MonoBehaviour {

	public GameObject helpText;
	public GameObject badges;
	public GameObject outro_Trans;
	public GameObject credits;

	public void showCredits() {
		helpText.SetActive (false);
		badges.SetActive (false);
		outro_Trans.SetActive (false);
		credits.SetActive (true);
	}
		
}
