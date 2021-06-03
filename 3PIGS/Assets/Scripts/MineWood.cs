using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineWood : MonoBehaviour
{
    public GameObject[] wood;
    public float mining;

    void Update()
    {
        if (mining >= 3)
        {
            wood[0].SetActive(true);
        }
        if (mining >= 6)
        {
            wood[1].SetActive(true);
        }
        if (mining >= 9)
        {
            wood[2].SetActive(true);
        }
        if (mining >= 12)
        {
            wood[3].SetActive(true);
        }
        if (mining >= 15)
        {
            wood[4].SetActive(true);
        }
        if (mining >= 18)
        {
            wood[5].SetActive(true);
        }
        if (mining >= 21)
        {
            wood[6].SetActive(true);
        }
        if (mining >= 24)
        {
            wood[7].SetActive(true);
        }
        if (mining >= 27)
        {
            wood[8].SetActive(true);
        }
        if (mining >= 30)
        {
            wood[9].SetActive(true);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("touching");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("Mining Wood...");
                mining = mining + 1;
            }
        }
    }
}
