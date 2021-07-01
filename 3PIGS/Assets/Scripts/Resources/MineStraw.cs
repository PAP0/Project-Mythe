using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineStraw : MonoBehaviour
{
    public GameObject[] straw;
    public float mining;

    void Update()
    {
        if (mining >= 3)
        {
            straw[0].SetActive(true);
        }
        if (mining >= 6)
        {
            straw[1].SetActive(true);
        }
        if (mining >= 9)
        {
            straw[2].SetActive(true);
        }
        if (mining >= 12)
        {
            straw[3].SetActive(true);
        }
        if (mining >= 15)
        {
            straw[4].SetActive(true);
        }
        if (mining >= 18)
        {
            straw[5].SetActive(true);
        }
        if (mining >= 21)
        {
            straw[6].SetActive(true);
        }
        if (mining >= 24)
        {
            straw[7].SetActive(true);
        }
        if (mining >= 27)
        {
            straw[8].SetActive(true);
        }
        if (mining >= 30)
        {
            straw[9].SetActive(true);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("touching");
            if (Input.GetButtonDown("P2Mine") || Input.GetButtonDown("P3Mine") || Input.GetButtonDown("P4Mine"))
            {
                Debug.Log("Mining Straw...");
                mining = mining + 1;
            }
        }
    }
}
