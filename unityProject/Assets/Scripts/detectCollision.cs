using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour {

	public GameObject boxDialogue;
	public GameObject sodaDialogue;
	public GameObject bottleDialogue;



	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "box"){
			boxDialogue.SetActive (true);
			sodaDialogue.SetActive (false);
			bottleDialogue.SetActive (false);

		}

		if (col.gameObject.name == "soda can"){
			boxDialogue.SetActive (false);
			sodaDialogue.SetActive (true);
			bottleDialogue.SetActive (false);


		}

		if (col.gameObject.name == "wata bottle"){
			boxDialogue.SetActive (false);
			sodaDialogue.SetActive (false);
			bottleDialogue.SetActive (true);

		}



	}

	public void boxTapAway() {
		boxDialogue.SetActive (false);
	}

	public void sodaTapAway() {
		sodaDialogue.SetActive (false);
	}

	public void bottleTapAway() {
		bottleDialogue.SetActive (false);
	}


}
