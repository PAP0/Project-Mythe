using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t3 : MonoBehaviour
{
    public bool t3b;
    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig3")
        {
            Debug.Log("P3");
            t3b = true;
        }
    }
}
