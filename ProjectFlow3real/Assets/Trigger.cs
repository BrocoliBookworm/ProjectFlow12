using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Note;
    public Rigidbody2D NoteRigidRed;
    public Rigidbody2D NoteRigidBlue;
    public Rigidbody2D NoteRigidGreen;
    public GameObject Spawn;
    public float speed = 4;
    public bool touched;

    void OnTriggerEnter2D(Collider2D other)
    { 
        {
            touched = true;
            switch (other.tag)
            {
                case "Red Note":
                    Invoke("SendNoteRed", (float)0);
                    break;
                case "Blue Note":
                    Invoke("SendNoteBlue", (float)0);
                    break;
                case "Green Note":
                    Invoke("SendNoteGreen", (float)0);
                    break;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Invoke("Reset",(float)0);
        Destroy(other);
        //touched = false;
    }
    void SendNoteRed()
    {
        if (touched == true)
        {
            var p = Instantiate(NoteRigidRed, transform.position, transform.rotation);
            p.velocity = (-transform.up * speed);
            touched = false;
            Destroy(NoteRigidRed);
        }
    }

    private void WaitForSeconds(int v)
    {
        throw new NotImplementedException();
    }

    void SendNoteBlue()
    {
        if (touched == true)
        {
            var p = Instantiate(NoteRigidBlue, transform.position, transform.rotation);
            p.velocity = (-transform.up * speed);
            touched = false;
        } 
    }
    void SendNoteGreen()
    {
        if (touched == true)
        {
            var p = Instantiate(NoteRigidGreen, transform.position, transform.rotation);
            p.velocity = (-transform.up * speed);
            touched = false;
            
        }
    }
    void Reset()
    {
        touched = false;
    }
}
