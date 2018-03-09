using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public class IfAnchorAddedScript : MonoBehaviour {

	private UnityARAnchorManager unityARAnchorManager;
	public GameObject FindFlatSurfaceIcon;
	public GameObject FindFlatSurfaceText;
	public GameObject TapToPlaceText;
	public GameObject ObjectFocusSquare;


	// Use this for initialization
	void Start () {
		unityARAnchorManager = new UnityARAnchorManager();
	}

	// Update is called once per frame
	void Update () {

		List<ARPlaneAnchorGameObject> arpags = unityARAnchorManager.GetCurrentPlaneAnchors ();
		if(arpags.Count > 0) {
			Debug.Log ("Plane Added");
			FindFlatSurfaceIcon.SetActive (false);
			FindFlatSurfaceText.SetActive (false);
			TapToPlaceText.SetActive (true);
			ObjectFocusSquare.SetActive (true);
		}

	}
}
