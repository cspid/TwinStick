using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {


    public float timer = 1;
    float time;
    public GameObject bullet;
    bool canFire;

	void Update () {
       
    if (Input.GetKey(KeyCode.Space))
    {
        Wait();
        if (canFire == true)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            canFire = false;
            time = 0;
        }
    }
}

    void Wait()
    {
        time += Time.deltaTime;
        if(time > timer){
            canFire = true;
        }
    }
}
