using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineStone : MonoBehaviour
{
    public GameObject[] stone;
    public float mining;

    void Update()
    {
        if (mining >= 3)
        {
            stone[0].SetActive(true);
        }
        if (mining >= 6)
        {
            stone[1].SetActive(true);
        }
        if (mining >= 9)
        {
            stone[2].SetActive(true);
        }
        if (mining >= 12)
        {
            stone[3].SetActive(true);
        }
        if (mining >= 15)
        {
            stone[4].SetActive(true);
        }
        if (mining >= 18)
        {
            stone[5].SetActive(true);
        }
        if (mining >= 21)
        {
            stone[6].SetActive(true);
        }
        if (mining >= 24)
        {
            stone[7].SetActive(true);
        }
        if (mining >= 27)
        {
            stone[8].SetActive(true);
        }
        if (mining >= 30)
        {
            stone[9].SetActive(true);
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("touching");
            if (Input.GetButtonDown("P2Mine") || Input.GetButtonDown("P3Mine") || Input.GetButtonDown("P4Mine"))
            {
                Debug.Log("Mining Stone...");
                mining = mining + 1;
            }
        }
    }
}
