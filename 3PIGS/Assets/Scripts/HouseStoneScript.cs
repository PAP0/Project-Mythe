using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseStoneScript : MonoBehaviour
{
    public pigInventoru pigInventoru;
    public GameObject[] StoneHouse;
    public int BuildStone;
    public bool isDone;

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Inventory")
        {
            Debug.Log("touching");
            if (Input.GetKeyDown(KeyCode.Q))
            {
                pigInventoru.RemoveStone();
                BuildStone = BuildStone + 1;
            }
        }
    }

    void Update()
    {
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
    }
}
