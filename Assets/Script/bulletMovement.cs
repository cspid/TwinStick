using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

	Rigidbody rb;
	public float bulletSpeed = 0.5f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.AddRelativeForce (0, bulletSpeed, 0, ForceMode.Impulse);
		//transform.GetChild(0).GetComponent<PartlesAreaManipulator>().particlesArea;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0, bulletSpeed, 0);
		Destroy (gameObject, 2.0f);
	}
}
