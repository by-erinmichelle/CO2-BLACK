using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(AudioSource))]
public class newScreen : MonoBehaviour {

	public GameObject Screen1;
	public GameObject Screen3;
	public GameObject Screen2;
	public GameObject smoke;

	public void secondScreen() {
		Screen1.SetActive (false);
		Screen2.SetActive (true);
	}
		
	public void visualize() {
//		if visualize button is clicked, hide second screen, show the third
		Screen2.SetActive (false);
		Screen3.SetActive (true);
		smoke.SetActive (true);
	}
		
}

//	attempt to get next audio clip to play once previous clip ends
//		public AudioClip otherClip;
//		AudioSource audioSource;
//	
//		void Start()
//		{
//			audioSource = GetComponent<AudioSource>();
//		}
//	
//		void Update()
//		{
//			if (audioSource.isPlaying == false)
//			{
//				audioSource.clip = otherClip;
//				audioSource.Play();
//			}
//		}

//		public AudioClip engineStartClip;
//		public AudioClip engineLoopClip;
//		void Start()
//		{
//			GetComponent<AudioSource> ().loop = true;
//			StartCoroutine(playEngineSound());
//		}
//
//		IEnumerator playEngineSound()
//		{
//			audio.clip = engineStartClip;
//			audio.Play();
//			yield return new WaitForSeconds(audio.clip.length);
//			audio.clip = engineLoopClip;
//			audio.Play();
//		}



//	attempt to get screens to change when audio clip ended
//	public AudioClip audio;
//	private AudioSource audiosource;
//
//	void Start()
//	{
//		audiosource = GetComponent<AudioSource>();
//		audiosource.clip = audio;
//		audiosource.Play();
//		StartCoroutine(WaitForSound(audio));
//	}
//
//	public IEnumerator WaitForSound(AudioClip Sound)
//	{
//		yield return new WaitUntil(() => audiosource.isPlaying == false);
//		// or yield return new WaitWhile(() => audiosource.isPlaying == true);
//		if(Screen1 != null)
//			Screen1.SetActive(false); //Do something
//	}