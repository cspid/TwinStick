using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public int health = 3;
    public GameObject killParticle;
    public GameObject hitParticle;
    GameObject instantiated;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 11)
        {
            if (health > 0)
            {
                print("HIT");
                Destroy(other.gameObject);
                instantiated = Instantiate(hitParticle, transform.position, other.transform.rotation);
                health--;
                Destroy(instantiated, 2.0f);
            }
            else
            {
                print("HIT");
                Destroy(other.gameObject);
                instantiated = Instantiate(killParticle, transform.position, other.transform.rotation);
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<Collider2D>().enabled = false;
                Destroy(gameObject, 3.0f);
                Destroy(instantiated, 2.0f);

            }
        }
    }
}
