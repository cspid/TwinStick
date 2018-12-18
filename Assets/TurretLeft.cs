using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLeft : MonoBehaviour
{
    Transform sibling;
    Vector3 rStickDir;

    void Start()
    {
        sibling = transform.parent.GetChild(0);
    }

    void Update()
    {
        transform.position = sibling.position;

        // We are going to read the input every frame
        Vector3 vNewInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);

        // Only do work if meaningful
        if (vNewInput.sqrMagnitude < 0.1f)
        {
            return;
        }

        // Apply the transform to the object  
        var angle = Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, -angle);
    }
}
