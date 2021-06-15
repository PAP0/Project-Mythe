using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDisable : MonoBehaviour
{
    public GameObject Pig;
    public GameObject Pig2;
    public GameObject Pig3;
    public GameObject Wolf;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Pig.GetComponent<ThirdPersonMovement>().enabled = true;
            Pig2.GetComponent<ThirdPersonMovement>().enabled = false;
            Pig3.GetComponent<ThirdPersonMovement>().enabled = false;
            Wolf.GetComponent<ThirdPersonMovement>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Pig.GetComponent<ThirdPersonMovement>().enabled = false;
            Pig2.GetComponent<ThirdPersonMovement>().enabled = true;
            Pig3.GetComponent<ThirdPersonMovement>().enabled = false;
            Wolf.GetComponent<ThirdPersonMovement>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            Pig.GetComponent<ThirdPersonMovement>().enabled = false;
            Pig2.GetComponent<ThirdPersonMovement>().enabled = false;
            Pig3.GetComponent<ThirdPersonMovement>().enabled = true;
            Wolf.GetComponent<ThirdPersonMovement>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            Pig.GetComponent<ThirdPersonMovement>().enabled = false;
            Pig2.GetComponent<ThirdPersonMovement>().enabled = false;
            Pig3.GetComponent<ThirdPersonMovement>().enabled = false;
            Wolf.GetComponent<ThirdPersonMovement>().enabled = true;
        }
    }
}
