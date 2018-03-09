using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactHit3 : MonoBehaviour {

	private Vector3 fact3OrigPos;
	private Vector3 fact3NewPos;

	void HitByRay () {
		Debug.Log ("I was hit by a Ray");

		fact3OrigPos = this.gameObject.transform.position;
		this.gameObject.transform.localPosition = new Vector3(1.5f, 0, 1.5f);

	}
}
