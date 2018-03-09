using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideFreeze : MonoBehaviour {

	public Rigidbody rb;


	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Bottom Collider")
		{
			rb = GetComponent<Rigidbody>();
//			rb.isKinematic = true;
			rb.constraints = RigidbodyConstraints.FreezePositionY;



			
		}
	}
		
}
