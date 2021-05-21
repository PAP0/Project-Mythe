using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseWoodScript : MonoBehaviour
{
    public pigInventoru pigInventoru;
    public GameObject WoodHouse;
    public int BuildWood;
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
        if (BuildWood >= 9)
        {
            WoodHouse.SetActive(true);
        }
    }
}