using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ZeroG : MonoBehaviour {
	Rigidbody2D rb;
    Vector3 dir;
    float thrust = 1;


    void Start () {
        rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W)) {
			rb.AddForce (new Vector2(0, 1.0f));
		}
		if (Input.GetKey(KeyCode.S)) {
			rb.AddForce (new Vector2(0, -1.0f));
		}
		if (Input.GetKey(KeyCode.A)) {
            rb.AddForce (new Vector2(-1.0f, 0));
		}
		if (Input.GetKey(KeyCode.D)) {
			rb.AddForce(new Vector2(1.0f, 0));
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
