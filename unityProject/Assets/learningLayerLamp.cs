using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learningLayerLamp : MonoBehaviour {


		public GameObject trashCan;

		private changeTrashColor trashScript;

		

		public GameObject lampLearningLayer;

		private bool isLayerUp = false;

		private bool isBadgeUp = false;

		public GameObject lampBadge;

		public GameObject closeBtn;

		public GameObject nextBtn;

		public GameObject progBtn;

		public GameObject firstModuleGroup;
		public GameObject allLamp;
		public GameObject lampModel;
		public GameObject lampStand;
		public GameObject lampCFL;
		public GameObject lampShade;

		public GameObject secondModuleGroup;
		public GameObject trashContainer;

		public GameObject congrats;


		// Use this for initialization
		void Start () {
			trashScript = trashCan.GetComponent<changeTrashColor> ();
		}
		

		public void layerUp(){



			if (isLayerUp == false) {


				lampLearningLayer.SetActive (true);
				lampLearningLayer.GetComponent<Animation> ().Play ("layerUp");
				isLayerUp = true;
				closeBtn.SetActive (true);
				isBadgeUp = false;



			} else if (isLayerUp == true) {



				lampLearningLayer.GetComponent<Animation> ().Play ("layerDown");
				isLayerUp = false;
				lampBadge.SetActive (true);
				lampBadge.GetComponent<Animation> ().Play ("badgeIn");
				isBadgeUp = true;
				nextBtn.SetActive (false);
				progBtn.SetActive (true);
				congrats.SetActive (true);



			}

		}

		public void layerClose(){

			if (!isBadgeUp) {

				isLayerUp = false;
				lampLearningLayer.GetComponent<Animation> ().Play ("layerDown");

				closeBtn.SetActive (false);



			} else if (isBadgeUp) {
				isLayerUp = false;
				lampBadge.SetActive (false);
				closeBtn.SetActive (false);
				progBtn.SetActive (false);
			}


		}

		public void goToSecondModule(){
			lampBadge.GetComponent<Animation> ().Play ("badge1Out");
			congrats.SetActive (false);
			progBtn.SetActive (false);
			closeBtn.SetActive (false);

	//		hide first module
			firstModuleGroup.SetActive (false);
			lampModel.SetActive (false);
			lampStand.SetActive (false);
			lampCFL.SetActive (false);
			lampShade.SetActive (false);
			allLamp.SetActive (false);

			//show second module
			secondModuleGroup.SetActive (true);
			trashContainer.SetActive (true);


		}








}
