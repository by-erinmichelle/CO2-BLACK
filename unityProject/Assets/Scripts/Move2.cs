using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.iOS;
using UnityEngine.EventSystems;

public class Move2 : MonoBehaviour {
	public GameObject instructions;

	//public GameObject bubblePrefab;
	private static GameObject objectSelect = null;
    private Rigidbody rb;

	public GameObject trashBagDialogue;
	public GameObject trashBagDialogue_trans;
	public GameObject boxDialogue;
	public GameObject boxDialogue_trans;
	public GameObject bottleDialogue;
	public GameObject bottleDialogue_trans;
	public GameObject foamCupDialogue;
	public GameObject foamCupDialogue_trans;
	public GameObject sodaDialogue;
	public GameObject sodaDialogue_trans;



	// Update is called once per frame
	void Update () {



		if (Input.touchCount > 0) {

			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began  && !EventSystem.current.IsPointerOverGameObject(0)) {
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit;

				if (Physics.Raycast (ray, out hit, 100)) {

                    if (hit.transform.gameObject.tag == "goodTrash" || 	 hit.transform.gameObject.tag == "badTrash"){
						objectSelect = hit.transform.gameObject;
						rb = objectSelect.GetComponent<Rigidbody>();
						instructions.SetActive (false);

						trashBagDialogue.SetActive(false);
						trashBagDialogue_trans.SetActive(false);

						boxDialogue.SetActive(false);
						boxDialogue_trans.SetActive(false);

						bottleDialogue.SetActive(false);
						bottleDialogue_trans.SetActive(false);

						foamCupDialogue.SetActive(false);
						foamCupDialogue_trans.SetActive(false);

						sodaDialogue.SetActive(false);
						sodaDialogue_trans.SetActive(false);
                    }
					
				}
			}

			Debug.Log ("Touch Position" + touch.position);
			if (touch.phase == TouchPhase.Moved && !EventSystem.current.IsPointerOverGameObject(0)) {
				Vector3 fingerPosition = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, .3f));
				objectSelect.transform.position = new Vector3(fingerPosition.x, fingerPosition.y, fingerPosition.z);

				trashBagDialogue.SetActive(false);
				trashBagDialogue_trans.SetActive(false);

				boxDialogue.SetActive(false);
				boxDialogue_trans.SetActive(false);

				bottleDialogue.SetActive(false);
				bottleDialogue_trans.SetActive(false);

				foamCupDialogue.SetActive(false);
				foamCupDialogue_trans.SetActive(false);

				sodaDialogue.SetActive(false);
				sodaDialogue_trans.SetActive(false);


			}

			if (touch.phase == TouchPhase.Stationary && !EventSystem.current.IsPointerOverGameObject(0)) {
				Vector3 fingerPosition = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, .3f));
				objectSelect.transform.position = new Vector3 (fingerPosition.x, fingerPosition.y, fingerPosition.z);
				rb.isKinematic = true;

				trashBagDialogue.SetActive(false);
				trashBagDialogue_trans.SetActive(false);

				boxDialogue.SetActive(false);
				boxDialogue_trans.SetActive(false);

				bottleDialogue.SetActive(false);
				bottleDialogue_trans.SetActive(false);

				foamCupDialogue.SetActive(false);
				foamCupDialogue_trans.SetActive(false);

				sodaDialogue.SetActive(false);
				sodaDialogue_trans.SetActive(false);



			} else {
				rb.isKinematic = false;
			}
				


            if (touch.phase == TouchPhase.Ended) {
				Debug.Log ("touch ended");
				objectSelect = null;

            }

		}
	}
}
