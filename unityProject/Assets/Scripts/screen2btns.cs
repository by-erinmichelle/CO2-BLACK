using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen2btns : MonoBehaviour {

	public GameObject desc1;
	public GameObject desc2;
	public GameObject pointer;
	public GameObject visualize;

	public void desc1btn() {
		desc1.SetActive (false);
		desc2.SetActive (true);
	}

	public void desc2btn() {
		desc2.SetActive (false);
		visualize.SetActive (true);
	}
}
