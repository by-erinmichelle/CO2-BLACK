using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadDelayIntro : MonoBehaviour {


	public void ModeSelect(){
		StartCoroutine ("Wait");
		Initiate.Fade("master6",Color.black,1.0f);
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (1.3f);
		Application.LoadLevel ("master6");
	}


}
