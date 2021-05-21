using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    public pighealth pighealth;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("touching");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                pighealth.takeDamage();
            }
        }
    }
}
