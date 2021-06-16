using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class househealth : healthscript
{
    public GameObject house;
    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Wolf")
        {
            Debug.Log("touching");
            if(Input.GetButton("Blow"))
            {
            takeDamage();
            if (health <= 1)
            {
                Destroy(house);
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
