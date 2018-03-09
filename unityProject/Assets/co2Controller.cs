using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;
using UnityEngine.EventSystems;

public class co2Controller : MonoBehaviour {

// First Building Fact to Tap to Replace

	public GameObject BuildingFact;
	public GameObject BuildingFact_Trans;
	public GameObject replaceBulb;
	public GameObject lampNew;

	public void BuildingFact_ReplaceBulb () {

		BuildingFact.SetActive (false);
		BuildingFact_Trans.SetActive (false);
		replaceBulb.SetActive (true);
		
	}

// Tap to Replace to dontForget Fact
	public GameObject dontForget;
	public GameObject dontForgetTrans;

	// public void ReplaceBulb_DontForget () {

	// 	replaceBulb.SetActive (false);
	// 	// ReplaceBulb_Trans.SetActive (false);
	// 	dontForgetTrans.SetActive (true);
	// 	dontForget.SetActive (true);
	// }

// dontForget Fact to TurnOff Dialogue
	public GameObject turnOff;
	public GameObject findFlatText;

	public void DontForget_TurnOff () {
		dontForgetTrans.SetActive (false);
		dontForget.SetActive (false);
		turnOff.SetActive (true);
		findFlatText.SetActive (false);
	
	}

// SECOND MODULE //

// Tap Box Dialogue Trans to remove

	public GameObject boxDialogue;
	public GameObject boxDialogue_trans;

	public void tapBoxDialogue_trans () {
		boxDialogue.SetActive(false);
		boxDialogue_trans.SetActive(false);
	}

// Tap Soda Dialogue Trans to remove 

	public GameObject sodaDialogue;
	public GameObject sodaDialogue_trans;

	public void tapSodaDialogue_trans () {
		sodaDialogue.SetActive(false);
		sodaDialogue_trans.SetActive(false);
	}

// Tap Bottle Dialogue Trans to remove

	public GameObject bottleDialogue;
	public GameObject bottleDialogue_trans;

	public void tapBottleDialogue_trans () {
		bottleDialogue.SetActive(false);
		bottleDialogue_trans.SetActive(false);
	}

// Tap Trash Bag Dialogue Trans to remove 

	public GameObject trashBagDialogue;
	public GameObject trashBagDialogue_trans;

	public void tapTrashDialogue_trans () {
		trashBagDialogue.SetActive(false);
		trashBagDialogue_trans.SetActive(false);
	}

// Tap Foam Cup Dialogue Trans to remove 

	public GameObject foamCupDialogue;
	public GameObject foamCupDialogue_trans;

	public void tapFoamDialogue_trans () {
		foamCupDialogue.SetActive(false);
		foamCupDialogue_trans.SetActive(false);
	}


//THIRD MODULE

		public GameObject fire;
		public GameObject fireDefault;
		public GameObject coal;
		public GameObject gas;
		public GameObject clean;

		public GameObject woodEnergy;
		public GameObject woodEnergy_Trans;

		public GameObject coalEnergy;
		public GameObject coalEnergy_Trans;

		public GameObject gasEnergy;
		public GameObject gasEnergy_Trans;

		public GameObject allEnergy;
		public GameObject allEnergy_Trans;

		public GameObject getClean;
		public GameObject getClean_Trans;

		public GameObject reject;
		public GameObject reject_Trans;

		public GameObject good;
		public GameObject good_Trans;

		public GameObject laptop;
		public GameObject table;
		public GameObject screen1;
		public GameObject screen2;
		public GameObject screen3;

		//	show coal model
		public void turnOnCoal() {
			woodEnergy.SetActive (false);
			woodEnergy_Trans.SetActive (false);
			coal.SetActive (true);
			coalEnergy.SetActive (true);
			coalEnergy_Trans.SetActive (true);

		}

		//	show gas model
		public void turnOnGas(){
			gas.SetActive (true);
			gasEnergy.SetActive (true);
			gasEnergy_Trans.SetActive (true);
			coalEnergy.SetActive (false);
			coalEnergy_Trans.SetActive (false);
		}

		//	show clean models
		public void turnOnAll(){
			gasEnergy.SetActive (false);
			gasEnergy_Trans.SetActive (false);
			clean.SetActive (true);
			allEnergy.SetActive (true);
//			allEnergy_Trans.SetActive (true);
//			gasEnergy.SetActive (false);
		}

		//	show "its simple" text
		public void turnOnCleanText() {
			allEnergy.SetActive (false);
//			allEnergy_Trans.SetActive (false);
//			getClean.SetActive (true);
//			getClean_Trans.SetActive (true);

		}
		//	void OnCollisionEnter(Collision collision) {	
		//		if (collision.gameObject.name == "fire" || collision.gameObject.name == "coal" || collision.gameObject.name == "gas") {
		//
		//			fireDefault.GetComponent<Animation> ().Play ();
		//			StartCoroutine (negativeCoroutine ());
		//
		//		}
		//	}




	
		

		void Update () {

			Debug.Log ("workin");

			int fingerCount = 0;
			foreach (Touch touch in Input.touches) {
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					fingerCount++;
			}

			if (fingerCount > 0)
				print("User has " + fingerCount + " finger(s) touching the screen");


			if (Input.touchCount > 0) {

				Debug.Log("touch");


				Touch touch = Input.GetTouch (0);
				if (touch.phase == TouchPhase.Began  && !EventSystem.current.IsPointerOverGameObject(0)) {

					Debug.Log("touch2");

					Ray ray = Camera.main.ScreenPointToRay (touch.position);
					RaycastHit hit;

					if (Physics.Raycast (ray, out hit, 100)) {

						Debug.Log("raysent");

					if (hit.transform.tag == "fire" || hit.transform.tag == "coal" || hit.transform.tag == "gas"){
							Debug.Log ("plz");

							getClean.SetActive (false);
							getClean_Trans.SetActive (false);
							allEnergy.SetActive (false);

							reject.SetActive (true);
//							reject_Trans.SetActive (true);

							Handheld.Vibrate();
							

							//						fireDefault.GetComponent<Animation> ().Play ();



						}
					else if (hit.transform.tag == "clean"){
						Debug.Log ("yay");

						getClean.SetActive (false);
						getClean_Trans.SetActive (false);
						allEnergy.SetActive (false);
						reject.SetActive (false);

						good.SetActive (true);
						good_Trans.SetActive (true);




					}



					}
				}
			}



		}
		

		//	hide all the models, show laptop first screen ui
		public void hideAllModels() {
			getClean.SetActive (false);
			fire.SetActive (false);
			coal.SetActive (false);
			gas.SetActive (false);
			clean.SetActive (false);
			good.SetActive (false);
			good_Trans.SetActive (false);
			laptop.SetActive (true);
			table.SetActive (true);
			screen1.SetActive (true);
			Debug.Log("boiiiii");
		}








}

