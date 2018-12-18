using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public Transform exit;
    bool disableOther;
    float time = 0;
    public float timer = 2;

    private void Update()
    {
        if (disableOther == true)
        {
            Disable();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.layer);
        if (other.gameObject.layer == 10)
        {
            exit.GetComponent<CircleCollider2D>().enabled = false;

            disableOther = true;
            other.transform.position = exit.position;
            time = 0;
        }
    }

    // Update is called once per frame
    void Disable()
    {

        time += Time.deltaTime;
        if (time > timer)
        {
            exit.GetComponent<CircleCollider2D>().enabled = true;
            disableOther = false;
        }
    }
}
