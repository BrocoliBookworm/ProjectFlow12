using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingNote : MonoBehaviour
{

    public Rigidbody2D projectileRed;
    public Rigidbody2D projectileBlue;
    public Rigidbody2D projectileGreen;
    bool wait = true;
    public float speed = 4;
    void Update()
    {
        if (wait == true){
            if (Input.GetKeyDown(KeyCode.A))
            {
                Invoke("SpawnRed", 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Invoke("SpawnBlue", 0);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                Invoke("SpawnGreen", 0);
            }
        }
    }
    void WaitRed()
    {
        wait = false;
        Invoke("MakeTrue",1);
    }
    void MakeTrue()
    {
        wait = true;
    }
    void SpawnRed()
    {
        Rigidbody2D p = Instantiate(projectileRed, transform.position, transform.rotation);
        p.velocity = transform.up * speed;
        Invoke("Wait", 0);
    }
    void SpawnGreen()
    {
        Rigidbody2D p = Instantiate(projectileGreen, transform.position, transform.rotation);
        p.velocity = transform.up * speed;
        Invoke("Wait", 0);
    }
    void SpawnBlue()
    {
        Rigidbody2D p = Instantiate(projectileBlue, transform.position, transform.rotation);
        p.velocity = transform.up * speed;
        Invoke("Wait", 0);
    }
}