using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t2 : MonoBehaviour
{
    public bool t2b;
    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig2")
        {
            Debug.Log("P2");
            t2b = true;
        }
    }
}
