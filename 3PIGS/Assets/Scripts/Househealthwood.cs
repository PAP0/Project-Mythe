using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Househealthwood : healthscript
{
    public HouseWoodScript HWS;
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
                    HWS.BuildWood = 0;
                    foreach (GameObject housepart in HWS.WoodHouse)
                    {
                        housepart.SetActive(false);
                    }
                }
            }
        }
    }
}
