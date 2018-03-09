using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactHit1 : MonoBehaviour {

	private Vector3 fact1OrigPos;
	private Vector3 fact1NewPos;

	void HitByRay () {
		Debug.Log ("I was hit by a Ray");

//		fact1OrigPos = this.gameObject.transform.position;
//		this.gameObject.transform.localPosition = new Vector3(1, 0, 1);

		Destroy (this.gameObject);

	}
}
	