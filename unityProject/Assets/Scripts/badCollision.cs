using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badCollision : MonoBehaviour {

	
	private bool hasCollide = false;

	

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Trash Can" && !hasCollide){

			Handheld.Vibrate();
			hasCollide = true;
			StartCoroutine(MyCoroutine());

			GetComponent<Animation>().Play();
			
			

		}

	}


	IEnumerator MyCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.5F);
		hasCollide = false;
	}

}




