using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class toggleTrash : MonoBehaviour {

    public GameObject lamp;
    public GameObject trash;

    public void toggleLamp() {
        Debug.Log("CLICKED");
        Destroy(lamp);
        trash.SetActive(true);

    }
}
