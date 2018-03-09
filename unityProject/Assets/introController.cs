using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introController : MonoBehaviour {
	public GameObject Screen1;
	public GameObject Screen2;
	public GameObject Screen3;
	public GameObject smoke;

	public GameObject s2d1;
	public GameObject s2d1_Trans;
	public GameObject s2d2;
	public GameObject s2d2_Trans;
	public GameObject pointer;
	public GameObject visualize;
	public GameObject visualize_Trans;

	public GameObject s3d1;
	public GameObject s3d1_Trans;
	public GameObject s3d2;
	public GameObject s3d2_Trans;
	public GameObject reduce;
	public GameObject reduce_Trans;

// Show next canvas/screen
	public void secondScreen() {
		Screen1.SetActive (false);
		Screen2.SetActive (true);
	}
		
	public void visualizeBtn() {
		//if visualize button is clicked, hide second screen, show the third
		Screen2.SetActive (false);
		Screen3.SetActive (true);
		smoke.SetActive (true);
	}


// Screen 2 buttons
	public void s2d1btn() {
		s2d1.SetActive (false);
		s2d1_Trans.SetActive (false);
		s2d2.SetActive (true);
		s2d2_Trans.SetActive (true);
	}

	public void s2d2btn() {
		s2d2.SetActive (false);
		s2d2_Trans.SetActive (false);
		visualize.SetActive (true);
		visualize_Trans.SetActive (true);
	}

// Screen 3 buttons
	public void s3d1btn() {
		s3d1.SetActive (false);
		s3d1_Trans.SetActive (false);
		s3d2.SetActive (true);
		s3d2_Trans.SetActive (true);
	}

	public void s3d2btn() {
		s3d2.SetActive (false);
		s3d2_Trans.SetActive (false);
		reduce.SetActive (true);
		reduce_Trans.SetActive (true);
	}

	public void thirdScreenHide() {
		Screen3.SetActive (false);
	}
}
