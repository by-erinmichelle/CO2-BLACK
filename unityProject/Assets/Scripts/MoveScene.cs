using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveScene : MonoBehaviour {



	void OnTriggerEnter ()
	{
		Application.LoadLevel ("Calluori01");
	}







	//{
		//if (other.CompareTag ("Player")) 
		//{
			//SceneManager.LoadScene ("Calluori01");
		//}
	//}

}
