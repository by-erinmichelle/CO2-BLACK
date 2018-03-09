using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixedpos : MonoBehaviour {

	public GameObject cfl;

	private Vector3 offset;

	void Start () {
		offset = transform.position = cfl.transform.position;
	}

	// Update is called once per frame

	void LateUpdate () {
		
		transform.position = cfl.transform.position + offset;
			
	}
}
