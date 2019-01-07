using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Rewired;

public class ZeroG : MonoBehaviour {
    public int playerID;
	Rigidbody2D rb;
    Vector3 dir;
    float thrust = 1;
    public float thrustBoost = 2;
    Vector3 rStickDir;
    float startThrust;
    public float brakeDrag = 2;
    float startDrag;
    public Player player;



    void Start () {
        rb = GetComponent<Rigidbody2D> ();
        startThrust = thrust;
        startDrag = rb.drag;

        player = ReInput.players.GetPlayer(playerID);
    }

    // Update is called once per frame
    void FixedUpdate () {
		
		
		transform.Rotate( rb.velocity);
        float h = (player.GetAxisRaw("Move Horizontal"));
        float v = (player.GetAxisRaw("Move Vertical"));

        //Brake
        if (player.GetButton("Brake"))
        {
            print("Brake");
            rb.drag = brakeDrag;
        }
        else
        {
            rb.drag = startDrag;
        }


        //Acceleate
        if (player.GetButton("Thrust"))
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
