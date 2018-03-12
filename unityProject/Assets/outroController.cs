using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outroController : MonoBehaviour {

	public GameObject screen1;

	public GameObject credits;

	public void showCredits() {
		screen1.SetActive (false);
		credits.SetActive (true);
	}
		
}
