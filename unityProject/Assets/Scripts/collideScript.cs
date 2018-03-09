using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideScript : MonoBehaviour {

	public GameObject showCube;

	private void OnTriggerEnter() {

		showCube.SetActive (true);

	}

}
