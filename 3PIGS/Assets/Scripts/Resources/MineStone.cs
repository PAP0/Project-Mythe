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
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("touching");
            if (Input.GetButtonDown("P2Mine") || Input.GetButtonDown("P3Mine") || Input.GetButtonDown("P4Mine"))
            {
                mining = mining + 1;
            }
        }
    }
}
