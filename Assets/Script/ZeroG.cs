using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ZeroG : MonoBehaviour {
	Rigidbody rb;
    Vector3 dir;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W)) {
			rb.AddForce (0, 1, 0);
		}
		if (Input.GetKey(KeyCode.S)) {
			rb.AddForce (0, -1, 0);
		}
		if (Input.GetKey(KeyCode.A)) {
			rb.AddForce (-1, 0, 0);
		}
		if (Input.GetKey(KeyCode.D)) {
			rb.AddForce (1, 0, 0);
		}

		transform.Rotate( rb.velocity);
        float h = (Input.GetAxisRaw("Horizontal"));
        float v = (Input.GetAxisRaw("Vertical"));

        transform.rotation = Quaternion.LookRotation(rb.velocity, Vector3.up);

        //if (System.Math.Abs(h) > Mathf.Epsilon || System.Math.Abs(v) > Mathf.Epsilon)
        // {
        //    dir.x = h;
        //    dir.z = v;
        //    transform.rotation(dir.normalized);
        //}

    }
}
