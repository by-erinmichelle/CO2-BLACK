using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learningLayerUp : MonoBehaviour {

	public GameObject trashCan;

	private changeTrashColor trashScript;

	private bool twoRejections;

	public GameObject trashLayer;

	private bool isLayerUp = false;

	private bool isBadgeUp = false;

	public GameObject trashBadge;

	public GameObject closeBtn;

	public GameObject nextBtn;

	public GameObject progBtn;

	public GameObject secondModuleGroup;
	public GameObject trashContainer;

	public GameObject thirdModuleGroup;
	public GameObject energyContainer;


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

	public GameObject congrats;


	// Use this for initialization
	void Start () {
		trashScript = trashCan.GetComponent<changeTrashColor> ();
	}
	
	// Update is called once per frame
	void Update () {
		twoRejections = trashScript.twoRejections;

		
	}

	public void layerUp(){

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

		if (isLayerUp == false) {
			

			trashLayer.SetActive (true);
			trashLayer.GetComponent<Animation> ().Play ("layerUp");
			isLayerUp = true;
			closeBtn.SetActive (true);
			isBadgeUp = false;



		} else if (isLayerUp == true) {
		
			

			trashLayer.GetComponent<Animation> ().Play ("layerDown");
			isLayerUp = false;
			trashBadge.SetActive (true);
			trashBadge.GetComponent<Animation> ().Play ("badgeIn");
			isBadgeUp = true;
			nextBtn.SetActive (false);
			progBtn.SetActive (true);
			congrats.SetActive (true);



		}

	}

	public void layerClose(){

		if (!isBadgeUp) {
			
			isLayerUp = false;
			trashLayer.GetComponent<Animation> ().Play ("layerDown");

			closeBtn.SetActive (false);



		} else if (isBadgeUp) {
			isLayerUp = false;
			trashBadge.SetActive (false);
			closeBtn.SetActive (false);
			progBtn.SetActive (false);
		}


	}

	public void goToThirdModule(){
		trashBadge.GetComponent<Animation> ().Play ("badgeOut");
		congrats.SetActive (false);
		progBtn.SetActive (false);
		closeBtn.SetActive (false);

		//hide second module
		secondModuleGroup.SetActive (false);
		trashContainer.SetActive (false);

		//show third module
		thirdModuleGroup.SetActive (true);
		energyContainer.SetActive (true);

	}




}
