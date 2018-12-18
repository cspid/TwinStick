using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

	Rigidbody2D rb;

	public float bulletSpeed = 0.5f;

    void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddRelativeForce (new Vector2(0, bulletSpeed), ForceMode2D.Impulse);
	}
	
	void Update () {
		Destroy (gameObject, 2.0f);
	}
}
