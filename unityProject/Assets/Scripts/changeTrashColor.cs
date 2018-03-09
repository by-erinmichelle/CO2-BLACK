using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTrashColor : MonoBehaviour {

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

		public GameObject nextTrash;

		private int interactionCount;
		public bool twoRejections = false;

		public bool trashOk = true;
		
		public bool trashHasCollided = false;
		public bool trashCanRun = true;

		public bool foamHasCollided = false;
		public bool foamCanRun = true;

		public bool bottleHasCollided = false;
		public bool bottleCanRun = true;

		public bool boxHasCollided = false;
		public bool boxCanRun = true;

		public bool sodaHasCollided = false;
		public bool sodaCanRun = true;


		
		

	void OnCollisionEnter(Collision collision)
	{	

		if(interactionCount > 2){
		
			nextTrash.SetActive (true);
		
		}


		if ((collision.gameObject.name == "trashbag" || collision.gameObject.name == "foam cup") && trashOk){

			GetComponent<Animation>().Play();
			StartCoroutine(negativeCoroutine());
			trashOk = false;
		}







		if (collision.gameObject.name == "trashbag"){

			trashBagDialogue.SetActive(true);
			trashBagDialogue_trans.SetActive(true);

			boxDialogue.SetActive(false);
			boxDialogue_trans.SetActive(false);

			bottleDialogue.SetActive(false);
			bottleDialogue_trans.SetActive(false);

			foamCupDialogue.SetActive(false);
			foamCupDialogue_trans.SetActive(false);
			
			sodaDialogue.SetActive(false);
			sodaDialogue_trans.SetActive(false);

			trashCanRun = false;
			StartCoroutine(trashCoroutine());

			if (!trashHasCollided) {
				trashHasCollided = true;
				interactionCount++;

			}
		}

		if (collision.gameObject.name == "box"){

			trashBagDialogue.SetActive(false);
			trashBagDialogue_trans.SetActive(false);

			boxDialogue.SetActive(true);
			boxDialogue_trans.SetActive(true);

			bottleDialogue.SetActive(false);
			bottleDialogue_trans.SetActive(false);

			foamCupDialogue.SetActive(false);
			foamCupDialogue_trans.SetActive(false);
			
			sodaDialogue.SetActive(false);
			sodaDialogue_trans.SetActive(false);

			boxCanRun = false;
			StartCoroutine(boxCoroutine());

			if (!boxHasCollided) {
				boxHasCollided = true;
				interactionCount++;

			}

		}


		if (collision.gameObject.name == "wata bottle"){

			trashBagDialogue.SetActive(false);
			trashBagDialogue_trans.SetActive(false);

			boxDialogue.SetActive(false);
			boxDialogue_trans.SetActive(false);

			bottleDialogue.SetActive(true);
			bottleDialogue_trans.SetActive(true);

			foamCupDialogue.SetActive(false);
			foamCupDialogue_trans.SetActive(false);
			
			sodaDialogue.SetActive(false);
			sodaDialogue_trans.SetActive(false);

			bottleCanRun = false;
			StartCoroutine(bottleCoroutine());

			if (!bottleHasCollided) {
				bottleHasCollided = true;
				interactionCount++;

			}

		}

		if (collision.gameObject.name == "foam cup"){

			trashBagDialogue.SetActive(false);
			trashBagDialogue_trans.SetActive(false);

			boxDialogue.SetActive(false);
			boxDialogue_trans.SetActive(false);

			bottleDialogue.SetActive(false);
			bottleDialogue_trans.SetActive(false);

			foamCupDialogue.SetActive(true);
			foamCupDialogue_trans.SetActive(true);
			
			sodaDialogue.SetActive(false);
			sodaDialogue_trans.SetActive(false);

			foamCanRun = false;
			StartCoroutine(foamCoroutine());

			if (!foamHasCollided) {
				foamHasCollided = true;
				interactionCount++;

			}

		}

		if (collision.gameObject.name == "soda can"){

			trashBagDialogue.SetActive(false);
			trashBagDialogue_trans.SetActive(false);

			boxDialogue.SetActive(false);
			boxDialogue_trans.SetActive(false);

			bottleDialogue.SetActive(false);
			bottleDialogue_trans.SetActive(false);

			foamCupDialogue.SetActive(false);
			foamCupDialogue_trans.SetActive(false);
			
			sodaDialogue.SetActive(true);
			sodaDialogue_trans.SetActive(true);

			sodaCanRun = false;
			StartCoroutine(sodaCoroutine());

			if (!sodaHasCollided) {
				sodaHasCollided = true;
				interactionCount++;

			}


		}

	}


	IEnumerator negativeCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.5F);
		trashOk = true;
	}

	IEnumerator trashCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.0F);
		trashCanRun = true;
	}

	IEnumerator boxCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.0F);
		boxCanRun = true;
	}

	IEnumerator sodaCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.0F);
		sodaCanRun = true;
	}

	IEnumerator bottleCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.0F);
		bottleCanRun = true;
	}

	IEnumerator foamCoroutine()
	{
		//disable the desired script here
		yield return new WaitForSeconds(1.0F);
		foamCanRun = true;
	}


}
