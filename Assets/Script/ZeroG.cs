using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Rewired;

public class ZeroG : MonoBehaviour {
	Rigidbody2D rb;
    Vector3 dir;
    float thrust = 1;
    public float thrustBoost = 2;
    Vector3 rStickDir;
    float startThrust;
    public float brakeDrag = 2;
    float startDrag;
    int player;



    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        startThrust = thrust;
        startDrag = rb.drag;
        
	}

	// Update is called once per frame
	void FixedUpdate () {
		
		
		transform.Rotate( rb.velocity);
        float h = (Input.GetAxisRaw("Horizontal"));
        float v = (Input.GetAxisRaw("Vertical"));

        //Brake
        if (Input.GetButton("Brake"))
        {
            print("Brake");
            rb.drag = brakeDrag;
        }
        else
        {
            rb.drag = startDrag;
        }


        //Acceleate
        if (Input.GetButton("Thrust"))
        {
            print("accelerate");
            thrust = thrustBoost;
        }
        else
        {
            thrust = startThrust;
        }

        rb.AddForce(new Vector2(h * thrust, v * thrust));
    }
    
}
