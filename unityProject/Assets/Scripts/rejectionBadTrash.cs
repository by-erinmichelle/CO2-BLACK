using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rejectionBadTrash : MonoBehaviour {
	
	public float thrust;
	public Rigidbody rb;

	void OnCollisionEnter(Collision collision)
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(0, thrust, 0, ForceMode.Impulse);
	}



}
