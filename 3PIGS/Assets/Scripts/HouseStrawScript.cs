using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseStrawScript : MonoBehaviour
{
    public pigInventoru pigInventoru1;
    public pigInventoru pigInventoru2;
    public pigInventoru pigInventoru3;
    public househealthstraw strawhealth;
    public GameObject[] StrawHouse;
    public bool isDone;
    public int BuildStraw;
    public bool canBuild1;
    public bool canBuild2;
    public bool canBuild3;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Inventory")
        {
            Debug.Log("touching");
            if(canBuild1 == true)
            {
                if(Input.GetButtonDown("P2Build"))
                {
                    pigInventoru1.RemoveStraw();
                    BuildStraw = BuildStraw + 1;
                }
            }
            if (canBuild2 == true)
            { 
                if (Input.GetButtonDown("P3Build"))
                {
                    pigInventoru2.RemoveStraw();
                    BuildStraw = BuildStraw + 1;
                }
            }

            if (canBuild3 == true)
            {
                if (Input.GetButtonDown("P4Build"))
                {
                    pigInventoru3.RemoveStraw();
                    BuildStraw = BuildStraw + 1;
                }
            }
        }
    }

    void Update()
    {
        if(pigInventoru1.AmountStraw > 0)
        {
            canBuild1 = true;
        }
        if (pigInventoru1.AmountStraw < 1)
        {
            canBuild1 = false;
        }
        if (pigInventoru2.AmountStraw > 0)
        {
            canBuild2 = true;
        }
        if (pigInventoru2.AmountStraw < 1)
        {
            canBuild2 = false;
        }
        if (pigInventoru3.AmountStraw > 0)
        {
            canBuild3 = true;
        }
        if (pigInventoru3.AmountStraw < 1)
        {
            canBuild3 = false;
        }
        #region BuildParts
        if (BuildStraw >= 1)
        {
            StrawHouse[0].SetActive(true);
        }
        if (BuildStraw >= 2)
        {
            StrawHouse[1].SetActive(true);
        }
        if (BuildStraw >= 3)
        {
            StrawHouse[2].SetActive(true);
        }
        if (BuildStraw >= 4)
        {
            StrawHouse[3].SetActive(true);
        }
        if (BuildStraw >= 5)
        {
            StrawHouse[4].SetActive(true);
        }
        if (BuildStraw >= 6)
        {
            StrawHouse[5].SetActive(true);
        }
        if (BuildStraw >= 7)
        {
            StrawHouse[6].SetActive(true);
        }
        if (BuildStraw >= 8)
        {
            StrawHouse[7].SetActive(true);
        }
        if (BuildStraw >= 9)
        {
            StrawHouse[8].SetActive(true);
        }
        if (BuildStraw >= 9.5)
        {
            StrawHouse[9].SetActive(true);
            isDone = true;
        }
        #endregion
    }
}