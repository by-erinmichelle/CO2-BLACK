using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fact1_script : MonoBehaviour {

	public GameObject fact1;

	public void bringForward(){
		fact1.transform.localPosition = new Vector3(0, 0, 1);
	}


}
