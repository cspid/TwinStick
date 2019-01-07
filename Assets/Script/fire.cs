using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class fire : MonoBehaviour {



    ZeroG zeroG;
    public float recoil;
    float time;
    public float timer = 0.2f;
    public GameObject bullet;
    bool canFire;
    public Transform turretR;
    public Transform turretL;
    public Transform spawnPoint;
    Rigidbody2D rb;
    GameObject newBullet;
    Vector3 spawnDir;
    Vector3 relativePos;
    Player player;
    int playerID;


    private void Start()
    {
        //sibling = transform.parent.GetChild(1);
        rb = GetComponent<Rigidbody2D>();
        zeroG = GetComponent<ZeroG>();
        
        player = ReInput.players.GetPlayer(zeroG.playerID);

    }
    void Update () {

        Debug.DrawRay(transform.position, new Vector3(rb.velocity.x, rb.velocity.y, 0));
        relativePos = new Vector3(rb.velocity.x, rb.velocity.y, 0);
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);

        if (player.GetAxisRaw("Fire") > 0)
    {
        Wait();
        if (canFire == true)
        {
             //if  we're not using the right stick, use the left
            print("Firing");

                if ((player.GetAxisRaw("Right Stick Horizontal") > -0.1f) && (player.GetAxisRaw("Right Stick Horizontal") < 0.1f) && (player.GetAxisRaw("Right Stick Vertical") > -0.1f) && (player.GetAxisRaw("Right Stick Vertical") < 0.1f))
                {
                    //  newBullet = Instantiate(bullet, transform.position, Quaternion.LookRotation(new Vector3(rb.velocity.x, rb.velocity.y, 0), Vector3.forward * -1));

                  //  var angle = Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;
                   // transform.rotation = Quaternion.Euler(0, 0, angle + 90);

                    newBullet = Instantiate(bullet, spawnPoint.position, turretL.rotation);
                   // newBullet.GetComponent<lineRendBullet>().firePoint = spawnPoint;


                    newBullet.transform.parent = null;
                    Recoil(newBullet.transform.forward, recoil);               
                    print("No right stick");                

                }
                else
                {
                    newBullet = Instantiate(bullet, spawnPoint.position, turretR.rotation);
                    //newBullet.GetComponent<lineRendBullet>().firePoint = spawnPoint;

                    newBullet.transform.parent = null;
                }
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

    void Recoil(Vector3 dir, float force)
    {

        rb.AddRelativeForce(dir * -force, ForceMode2D.Impulse);
    }
}
