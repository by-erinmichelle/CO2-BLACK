using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadDelayIntro2 : MonoBehaviour {


	public void ModeSelect(){
		StartCoroutine ("Wait");
		Initiate.Fade("WiegmanRussoContrast",Color.black,1.0f);
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (1.3f);
		Application.LoadLevel ("WiegmanRussoContrast");
	}


}

