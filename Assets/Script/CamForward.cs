using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamForward : MonoBehaviour {

	public float camSpeed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (camSpeed, 0, 0);
	}
}
