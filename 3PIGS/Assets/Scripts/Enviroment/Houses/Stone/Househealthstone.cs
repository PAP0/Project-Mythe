using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Househealthstone : healthscript
{
    public HouseStoneScript HRS;
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
                    HRS.BuildStone = 0;
                    foreach (GameObject housepart in HRS.StoneHouse)
                    {
                        housepart.SetActive(false);
                    }
                }
            }
        }
    }
}
