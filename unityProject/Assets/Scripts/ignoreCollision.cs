using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollision : MonoBehaviour {
	
	public Transform goodTrash;
	public Transform goodTrash2;
	public Transform goodTrash3;

//	public GameObject bigBlocker;
//	Collider bigBlockCollider;
//	bigBlockerCollider = bigBlocker.getComponent<Collider>()

	void Start() {

		Physics.IgnoreCollision(goodTrash.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(goodTrash2.GetComponent<Collider>(), GetComponent<Collider>());
		Physics.IgnoreCollision(goodTrash3.GetComponent<Collider>(), GetComponent<Collider>());

	}

	public GameObject trashDialogue;
	public GameObject foamDialogue;

	// void OnTriggerEnter(Collision col){
		



	// 	if (col.gameObject.name == "trashbag"){
	// 		Debug.Log ("AHhhhhhhhhhhHHHHHHHHHhhhhhhhhhhhHHHHHHHHHHHhhhhhhhhhhhhhhhhhhhhhHHHHHHHHHHHHHHHHHHHHHHH");

	// 		trashDialogue.SetActive (true);
	// 		foamDialogue.SetActive (false);

	// 	}

	// 	if (col.gameObject.name == "foam cup"){
	// 		Debug.Log ("AHhhhhhhhhhhHHHHHHHHHhhhhhhhhhhhHHHHHHHHHHHhhhhhhhhhhhhhhhhhhhhhHHHHHHHHHHHHHHHHHHHHHHH");
			

	// 		trashDialogue.SetActive (false);
	// 		foamDialogue.SetActive (true);

	// 	}




	// }

	public void trashTapAway() {
		trashDialogue.SetActive (false);
	}

	public void foamTapAway() {
		foamDialogue.SetActive (false);
	}





}