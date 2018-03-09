using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontForget_turnOff : MonoBehaviour {

	public GameObject dontForget;
	public GameObject dontForgetTrans;
	public GameObject turnOff;

	public void dontForgetBtn () {
		dontForgetTrans.SetActive (false);
		dontForget.SetActive (false);
		turnOff.SetActive (true);
	}
}
