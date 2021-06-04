using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseWoodScript : MonoBehaviour
{
    public pigInventoru pigInventoru;
    public GameObject[] WoodHouse;
    public int BuildWood;
    public bool isDone;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Inventory")
        {
            Debug.Log("touching");
            if (Input.GetKeyDown(KeyCode.Q))
            {
                pigInventoru.RemoveWood();
                BuildWood = BuildWood + 1;
            }
        }
    }

    void Update()
    {
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
    }
}