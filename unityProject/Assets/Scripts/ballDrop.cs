using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballDrop : MonoBehaviour {

	public GameObject sphereContainer;
	
	public void ballFall(){
		sphereContainer.SetActive (true);
	}
}
