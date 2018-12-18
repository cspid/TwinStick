using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityPos : MonoBehaviour
{
    Transform p;
    Rigidbody2D pRb;
    Quaternion newRot;
    Quaternion offSet;
    VelocityManipulator vm;
    public float velRadius;
    public float velSpeed;
    public float vorSpeed = 0.1f;
    float startRadius;
    float startSpeed;

    public bool velDriver;
    FluidSimulator FS;

    // Start is called before the first frame update
    void Start()
    {
        p = transform.parent.GetChild(0);
        pRb = p.GetComponent<Rigidbody2D>();
        vm = GetComponent<VelocityManipulator>();
        startRadius = vm.m_radius;
        startSpeed = vm.m_fluidVelocitySpeed;
        FS = GetComponent<VelocityManipulator>().m_fluid;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = p.transform.position;
        if (velDriver)
        {
           // print(pRb.velocity.magnitude);
            vm.m_radius = startRadius + pRb.velocity.magnitude * velRadius;
            vm.m_fluidVelocitySpeed = startSpeed + pRb.velocity.magnitude * velSpeed;
            FS.Vorticity = pRb.velocity.magnitude * vorSpeed;
        }
    }
}
