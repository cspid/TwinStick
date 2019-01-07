using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRendBullet : MonoBehaviour
{
    TrailRenderer tr;
    Vector3[] positions;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        positions = new Vector3[2];
        tr = GetComponent<TrailRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
       // tr.SetPosition(0, firePoint.transform.position);
       // tr.SetPosition(1, transform.position);

       //positions = new Vector3[2];
        //tr.SetPositions(positions);
    }
}
