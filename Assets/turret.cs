using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class turret : MonoBehaviour
{

    Transform sibling;
    Player player; 

    void Start()
    {
        sibling = transform.parent.GetChild(0);
        player = ReInput.players.GetPlayer(sibling.GetComponent<ZeroG>().playerID);
        print(player);

    }
    
        void Update()
        {
           transform.position = sibling.position;

            // We are going to read the input every frame
            Vector3 vNewInput = new Vector3(player.GetAxisRaw("Right Stick Horizontal"), player.GetAxisRaw("Right Stick Vertical"), 0.0f);

                // Only do work if meaningful
                if (vNewInput.sqrMagnitude < 0.1f)
                {
                    return;
                }

                // Apply the transform to the object  
                var angle = Mathf.Atan2(player.GetAxis("Right Stick Horizontal"), player.GetAxis("Right Stick Vertical")) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, 0, angle);
              //   print("h = " + player.GetAxis("Right Stick Horizontal") + "v = " + player.GetAxis("Left Stick Hoizontal"));
    }
}
