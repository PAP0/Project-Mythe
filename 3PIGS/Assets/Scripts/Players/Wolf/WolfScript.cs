using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfScript : MonoBehaviour
{
    public pighealth pighealth;
    public pighealth pighealth2;
    public pighealth pighealth3;

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
            if (Input.GetButtonDown("Attack"))
            {
                pighealth.takeDamage();
            }
        }
        if (collision.tag == "Pig2")
        {
            Debug.Log("touching");
            if (Input.GetButtonDown("Attack"))
            {
                pighealth2.takeDamage();
            }
        }
        if (collision.tag == "Pig3")
        {
            Debug.Log("touching");
            if (Input.GetButtonDown("Attack"))
            {
                pighealth3.takeDamage();
            }
        }
    }
}
