using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllernumber : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("p1test"))
        {
            Debug.Log("Controller1"); 
        }
        if (Input.GetButtonDown("p2test"))
        {
            Debug.Log("Controller2");
        }
        if (Input.GetButtonDown("p3test"))
        {
            Debug.Log("Controller3");
        }
        if (Input.GetButtonDown("p4test"))
        {
            Debug.Log("Controller4");
        }
    }
}
