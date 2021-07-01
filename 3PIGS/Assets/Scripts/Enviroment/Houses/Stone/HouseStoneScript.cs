using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseStoneScript : MonoBehaviour
{
    public pigInventoru pigInventoru1;
    public pigInventoru pigInventoru2;
    public pigInventoru pigInventoru3;
    public Househealthstone stonehealth;
    public GameObject[] StoneHouse;
    public int BuildStone;
    public bool isDone;
    public bool canBuild1;
    public bool canBuild2;
    public bool canBuild3;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Inventory")
        {
            if (canBuild1 == true)
            {
                if (Input.GetButtonDown("P2Build"))
                {
                    pigInventoru1.RemoveStone();
                    BuildStone = BuildStone + 1;
                }
            }
            if (canBuild2 == true)
            {

                if (Input.GetButtonDown("P3Build"))
                {
                    pigInventoru2.RemoveStone();
                    BuildStone = BuildStone + 1;
                }
            }
            if (canBuild3 == true)
            {
                if (Input.GetButtonDown("P4Build"))
                {
                    pigInventoru3.RemoveStone();
                    BuildStone = BuildStone + 1;
                }
            }
        }
    }

    void Update()
    {
        if (pigInventoru1.AmountStone > 0)
        {
            canBuild1 = true;
        }
        if (pigInventoru1.AmountStone < 1 )
        {
            canBuild1 = false;
        }
        if (pigInventoru2.AmountStone > 0)
        {
            canBuild2 = true;
        }
        if (pigInventoru2.AmountStone < 1)
        {
            canBuild2 = false;
        }
        if (pigInventoru3.AmountStone > 0)
        {
            canBuild3 = true;
        }
        if (pigInventoru3.AmountStone < 1)
        {
            canBuild3 = false;
        }
        #region BuildParts
        if (BuildStone >= 1)
        {
            StoneHouse[0].SetActive(true);
        }
        if (BuildStone >= 2)
        {
            StoneHouse[1].SetActive(true);
        }
        if (BuildStone >= 3)
        {
            StoneHouse[2].SetActive(true);
        }
        if (BuildStone >= 4)
        {
            StoneHouse[3].SetActive(true);
        }
        if (BuildStone >= 5)
        {
            StoneHouse[4].SetActive(true);
        }
        if (BuildStone >= 6)
        {
            StoneHouse[5].SetActive(true);
        }
        if (BuildStone >= 7)
        {
            StoneHouse[6].SetActive(true);
        }
        if (BuildStone >= 8)
        {
            StoneHouse[7].SetActive(true);
        }
        if (BuildStone >= 9)
        {
            StoneHouse[8].SetActive(true);
        }
        if (BuildStone >= 9.5)
        {
            StoneHouse[9].SetActive(true);
            isDone = true;
        }
        #endregion
    }
}