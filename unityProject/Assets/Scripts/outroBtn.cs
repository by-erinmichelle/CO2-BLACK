using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outroBtn : MonoBehaviour {

	public void ModeSelect(){
		StartCoroutine ("Wait");
		Initiate.Fade("Outro2",Color.black,1.0f);
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (1.3f);
		Application.LoadLevel ("Outro2");
	}
}
