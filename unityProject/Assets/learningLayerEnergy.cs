using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learningLayerEnergy : MonoBehaviour {


		public GameObject energyLearningLayer;

		private bool isLayerUp = false;

		private bool isBadgeUp = false;

		public GameObject energyBadge;

		public GameObject closeBtn;

		public GameObject nextBtn;

		public GameObject progBtn;

		public GameObject congrats;


		public void layerUp(){



			if (isLayerUp == false) {


				energyLearningLayer.SetActive (true);
				energyLearningLayer.GetComponent<Animation> ().Play ("layerUp");
				isLayerUp = true;
				closeBtn.SetActive (true);
				isBadgeUp = false;



			} else if (isLayerUp == true) {



				energyLearningLayer.GetComponent<Animation> ().Play ("layerDown");
				isLayerUp = false;
				energyBadge.SetActive (true);
				energyBadge.GetComponent<Animation> ().Play ("badgeIn");
				isBadgeUp = true;
				nextBtn.SetActive (false);
				progBtn.SetActive (true);
				congrats.SetActive (true);



			}

		}

		public void layerClose(){

			if (!isBadgeUp) {

				isLayerUp = false;
				energyLearningLayer.GetComponent<Animation> ().Play ("layerDown");

				closeBtn.SetActive (false);



			} else if (isBadgeUp) {
				isLayerUp = false;
				energyBadge.SetActive (false);
				closeBtn.SetActive (false);
				progBtn.SetActive (false);
			}


		}
		








}
