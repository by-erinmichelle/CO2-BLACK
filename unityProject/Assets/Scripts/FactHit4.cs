using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactHit4 : MonoBehaviour {

	private Vector3 fact4OrigPos;
	private Vector3 fact4NewPos;

	void HitByRay () {
		Debug.Log ("I was hit by a Ray");

		fact4OrigPos = this.gameObject.transform.position;
		this.gameObject.transform.localPosition = new Vector3(2, 0, 2);

	}
}