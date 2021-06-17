using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1 : MonoBehaviour
{
    public bool t1b;
    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("P1");
            t1b = true;
        }
    }
}
