using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseStrawScript : MonoBehaviour
{
    public pigInventoru pigInventoru;
    public GameObject[] StrawHouse;
    public bool isdone;
    public int BuildStraw;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Inventory")
        {
            Debug.Log("touching");
            if(Input.GetKeyDown(KeyCode.Q))
            {
                pigInventoru.RemoveStraw();
                BuildStraw = BuildStraw + 1;
            }
        }
    }

    void Update()
    {
        if(BuildStraw >= 1)
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
        }
    }
}
