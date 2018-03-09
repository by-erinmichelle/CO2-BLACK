using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensivityX = 4.0f;
	private float sensivityY = 1.0f;

	private void Start() {
		camTransform = transform;
		cam = Camera.main;

	}

}
