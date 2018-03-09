using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactHit2 : MonoBehaviour {

	private Vector3 fact2OrigPos;
	private Vector3 fact2NewPos;

	public GameObject spotlightObject;
	public GameObject spotlightObject1;
	public GameObject TapToText;
	public GameObject SmokeParent;
	public GameObject SmokeParentLite;
	public GameObject buildingsText;

	void HitByRay () {
		Debug.Log ("I was hit by a Ray");
//
//		fact2OrigPos = this.gameObject.transform.position;
//		this.gameObject.transform.localPosition = new Vector3(-1.25f, 0, -1.25f);


		spotlightObject.SetActive (false);
		spotlightObject1.SetActive (false);

		TapToText.SetActive (false);
		SmokeParent.SetActive (false);
		SmokeParentLite.SetActive (true);
		buildingsText.SetActive (true);

	}
}

