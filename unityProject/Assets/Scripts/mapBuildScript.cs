using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapBuildScript : MonoBehaviour {

	public GameObject smoke;

	public GameObject spheres;

	public void toggleSmoke() {
		
		if (!smoke.activeInHierarchy) {
			
			smoke.SetActive(true);

		} else {

			smoke.SetActive(false);
			
		}

	}

	public void toggleSpheres() {

		if (!spheres.activeInHierarchy) {

			spheres.SetActive(true);

		} else {

			spheres.SetActive(false);

		}

	}




}
