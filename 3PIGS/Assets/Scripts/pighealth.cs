using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pighealth : healthscript
{
    public Transform PlayerTransform;

    public Transform TeleportGoal;
    public bool isDead;

    public GameObject pig;

    //-------------------------------

    void Start()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Wolf")
        {
            Debug.Log("touching");
        }
    }

    void Update()
    {
        if (health <= 0.9)
        {
            isDead = true;
            Debug.Log("pig dedded");
            if(isDead == true)
            {
                //PlayerTransform.position = TeleportGoal.position;
            }
        }
    }


    /*void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Wolf")
        {
            PlayerTransform.position = TeleportGoal.position;
        }
    }*/
}
