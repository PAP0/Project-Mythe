using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseStrawScript : MonoBehaviour
{
    public pigInventoru pigInventoru;
    public GameObject StrawHouse;
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
        if(BuildStraw >= 9)
        {
            StrawHouse.SetActive(true);
        }
    }
}
