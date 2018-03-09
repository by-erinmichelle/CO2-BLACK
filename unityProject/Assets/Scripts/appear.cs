//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class appear : MonoBehaviour {
//
//	public GameObject molecule;
//	public GameObject tapButton;
//	public GameObject visualizeButton;
//	public GameObject fact1;
//	public GameObject fact2; 
//	public GameObject fact3;
//	public GameObject fact4; 
//	public GameObject smoke;
//	public GameObject cam;
//
//
//	private float distance = 3.0f;
//
//
//
//	public void Set_Active(){
//
//		molecule.SetActive (true);
//		tapButton.SetActive (false);
//		smoke.SetActive (false);
//		fact1.SetActive (true);
//		fact2.SetActive (true);
//		fact3.SetActive (true);
//		fact4.SetActive (true);
//
//		if (fact1.active) {
//			molecule.SetActive (false);
//			smoke.SetActive (true);
//			visualizeButton.SetActive (true);
//		
////			fact1.transform.position = cam.transform.forward;
////			fact1.transform.position = cam.transform.position;
//
////			Debug.Log (fact1.transform.position);
////			fact1.transform.position = fact1.transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
////			Debug.Log (fact1.transform.position);
////			(cam.transform.position+(cam.transform.right)) + (cam.transform.forward * (0.5f*distance))
////			(cam.transform.position-cam.transform.right) + (cam.transform.forward * (1.25f*distance))
////			(cam.transform.position+cam.transform.right) + (cam.transform.forward * (1.0f*distance))
////			cam.transform.position + (cam.transform.forward * (0.75f*distance))
////
////			fact4.transform.position = (cam.transform.position-cam.transform.right) + (cam.transform.forward * (1.25f*distance));
//
////			(cam.transform.position-cam.transform.right) + (cam.transform.forward * (0.5f*distance));
//
//			fact1.transform.position = (cam.transform.position-cam.transform.right) + (cam.transform.forward * (0.5f*distance));
//			fact1.transform.rotation = new Quaternion( 0.0f, cam.transform.rotation.y, 0.0f, cam.transform.rotation.w );
//			fact2.transform.position = cam.transform.position + (cam.transform.forward * (0.75f*distance));
//			fact2.transform.rotation = new Quaternion( 0.0f, cam.transform.rotation.y, 0.0f, cam.transform.rotation.w );
//			fact3.transform.position = (cam.transform.position+cam.transform.right) + (cam.transform.forward * (1.0f*distance));
//			fact3.transform.rotation = new Quaternion( 0.0f, cam.transform.rotation.y, 0.0f, cam.transform.rotation.w );
//			fact4.transform.position = (cam.transform.position+(cam.transform.right*2.0f)) + (cam.transform.forward * (1.25f*distance));
//			fact4.transform.rotation = new Quaternion( 0.0f, cam.transform.rotation.y, 0.0f, cam.transform.rotation.w );
////			fact1.transform.localPosition = new Vector3(0, 0, 1);
////			fact2.transform.localPosition = new Vector3(-1, 0, 1);
////			fact3.transform.localPosition = new Vector3(1, 0, 1);
////			fact4.transform.localPosition = new Vector3(2, 0, 1);
//
//
//
//
//
//	
////			Vector3 offset = fact1.position - lastPos;
////			if (offset.x > 0.0f) {
////				lastPos = fact1.position;
////
////				fact2.SetActive (true);
////			}
//		}
//				
////
////		Vector3 offset = obj.position - lastPos;
////		if (offset.x > threshold){
////			lastPos = obj.position; // update lastPos
////			// code to execute when X is getting bigger
//
//
//		molecule.transform.SetParent(null);
//
////		Debug.Log (fact1.transform.position);
//	}
//
//
//}
