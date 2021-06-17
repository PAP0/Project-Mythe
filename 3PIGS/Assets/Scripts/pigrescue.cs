using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigrescue : MonoBehaviour
{
    public Transform PlayerTransform;

    public Transform TeleportGoal;
    public pighealth pighealth;

    public GameObject pig;

    //-------------------------------

    void Start()
    {

    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig" || collision.tag == "Pig2" || collision.tag == "Pig3")
        {
            Debug.Log("touching");
            if (Input.GetButtonDown("P2Rescue") || Input.GetButtonDown("P3Rescue") || Input.GetButtonDown("P4Rescue"))
            {
                PlayerTransform.position = TeleportGoal.position;
                pighealth.health = 30;
                Debug.Log("pig rescued");
            }
        }
    }

    void Update()
    {
    }
}
