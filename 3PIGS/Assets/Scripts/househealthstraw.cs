using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class househealthstraw : healthscript
{
    public HouseStrawScript HSS;
    public GameObject house;
    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Wolf")
        {
            if (Input.GetButton("Blow"))
            {
                takeDamage();
                if (health <= 1)
                {
                    HSS.BuildStraw = 0;
                    foreach(GameObject housepart in HSS.StrawHouse)
                    {
                        housepart.SetActive(false);
                    }
                }
            }
        }
    }
}
