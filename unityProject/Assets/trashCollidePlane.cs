using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCollidePlane : MonoBehaviour {

    public GameObject trashFirstInstructionText;
    public GameObject moveCloserText;

    private bool betterInstr = false;

	private void Awake()
	{
        StartCoroutine(pauseInstrText());
	}



	void OnCollisionEnter(Collision collide)
    {
        if (collide.gameObject.name == "Trash Can")
        {
            betterInstr = false;
            StartCoroutine(pauseInstrText());

        }

        else if (collide.gameObject.name == "botPlane" && betterInstr)
        {
            moveCloserText.SetActive(true);
            trashFirstInstructionText.SetActive(false);

            betterInstr = true;

            StartCoroutine(pauseInstrText());

        }
    }


    IEnumerator pauseInstrText()
    {
        //disable the desired script here
        yield return new WaitForSeconds(1.0F);
        betterInstr = true;
    }
}
