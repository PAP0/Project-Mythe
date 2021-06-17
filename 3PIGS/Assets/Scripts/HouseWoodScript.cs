using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseWoodScript : MonoBehaviour
{
    public pigInventoru pigInventoru1;
    public pigInventoru pigInventoru2;
    public pigInventoru pigInventoru3;
    public GameObject[] WoodHouse;
    public int BuildWood;
    public bool isDone;
    public bool canBuild1;
    public bool canBuild2;
    public bool canBuild3;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Inventory")
        {
            Debug.Log("touching");
            if (canBuild1 == true)
            {
                if (Input.GetButtonDown("P2Build"))
                {
                    pigInventoru1.RemoveWood();
                    BuildWood = BuildWood + 1;
                }
            }
            if (canBuild2 == true)
            {
                if (Input.GetButtonDown("P3Build"))
                {
                    pigInventoru2.RemoveWood();
                    BuildWood = BuildWood + 1;
                }
            }
            if (canBuild3 == true)
            {
                if (Input.GetButtonDown("P4Build"))
                {
                    pigInventoru1.RemoveWood();
                    BuildWood = BuildWood + 1;
                }
            }
        }
    }

    void Update()
    {
        if (pigInventoru1.AmountWood > 0)
        {
            canBuild1 = true;
        }
        if (pigInventoru1.AmountWood < 1)
        {
            canBuild1 = false;
        }
        if (pigInventoru2.AmountWood > 0)
        {
            canBuild2 = true;
        }
        if (pigInventoru2.AmountWood < 1)
        {
            canBuild2 = false;
        }
        if (pigInventoru3.AmountWood > 0)
        {
            canBuild3 = true;
        }
        if (pigInventoru3.AmountWood < 1)
        {
            canBuild3 = false;
        }
        #region Buildparts
        if (BuildWood >= 1)
        {
            WoodHouse[0].SetActive(true);
        }
        if (BuildWood >= 2)
        {
            WoodHouse[1].SetActive(true);
        }
        if (BuildWood >= 3)
        {
            WoodHouse[2].SetActive(true);
        }
        if (BuildWood >= 4)
        {
            WoodHouse[3].SetActive(true);
        }
        if (BuildWood >= 5)
        {
            WoodHouse[4].SetActive(true);
        }
        if (BuildWood >= 6)
        {
            WoodHouse[5].SetActive(true);
        }
        if (BuildWood >= 7)
        {
            WoodHouse[6].SetActive(true);
        }
        if (BuildWood >= 8)
        {
            WoodHouse[7].SetActive(true);
        }
        if (BuildWood >= 9)
        {
            WoodHouse[8].SetActive(true);
        }
        if (BuildWood >= 9.5)
        {
            WoodHouse[9].SetActive(true);
            isDone = true;
        }
        #endregion
    }
}