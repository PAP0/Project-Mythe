using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class househealth : healthscript
{

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Wolf")
        {
            if(Input.GetKeyDown(KeyCode.Space))
            { 
                takeDamage();
                if (health <= 1)
                {
                    Debug.Log("house dedded");
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Blow()
    {

    }
}
