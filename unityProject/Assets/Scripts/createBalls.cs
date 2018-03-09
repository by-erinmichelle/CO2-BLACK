using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBalls : MonoBehaviour {

	public Transform prefab;
	public void ballClone()
	{
		for (int i = -8; i < 45; i++)
		{
			Instantiate(prefab, new Vector3(i * 2.0F, 5, 0), Quaternion.identity);
			//2 units apart(x coordinate * 2), y coordinate, z coordinate
			//initial I = x coordinate

//			option to generate random grid of balls?
//			if (i <= 0 || i >= 47) {
//				Instantiate (prefab, new Vector3 (i * 2.0F, 5, 5), Quaternion.identity);
//			} else if (i >= 1 && i <= 15) {
//				Instantiate (prefab, new Vector3 (i * 2.0F, 5, 10), Quaternion.identity);
//			} else {
//				Instantiate (prefab, new Vector3 (i * 2.0F, 5, 0), Quaternion.identity);
//			}

		}
		for (int i = -8; i < 45; i++)
		{
			Instantiate(prefab, new Vector3(i * 2.0F, 5, 5), Quaternion.identity);
		}
		for (int i = -8; i < 45; i++)
		{
			Instantiate(prefab, new Vector3(i * 2.0F, 5, 10), Quaternion.identity);
		}
		for (int i = -8; i < 45; i++)
		{
			Instantiate(prefab, new Vector3(i * 2.0F, 5, 15), Quaternion.identity);
		}
		for (int i = -8; i < 45; i++)
		{
			Instantiate(prefab, new Vector3(i * 2.0F, 5, 20), Quaternion.identity);
		}
	}
}
