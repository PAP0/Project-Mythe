using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDisable : MonoBehaviour
{
    public GameObject Pig;
    public GameObject Wolf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Pig.GetComponent<ThirdPersonMovement>().enabled = true;
            Wolf.GetComponent<ThirdPersonMovement>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Pig.GetComponent<ThirdPersonMovement>().enabled = false;
            Wolf.GetComponent<ThirdPersonMovement>().enabled = true;
        }
    }
}
