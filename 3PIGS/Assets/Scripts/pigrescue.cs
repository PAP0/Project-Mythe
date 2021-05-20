using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigrescue : MonoBehaviour
{
    public Transform PlayerTransform;

    public Transform TeleportGoal;

    public GameObject pig;

    //-------------------------------

    void Start()
    {
        PlayerTransform = GameObject.Find("pig").transform;
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Pig")
        {
            Debug.Log("touching");
            if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerTransform.position = TeleportGoal.position;
                Debug.Log("pig rescued");
            }
        }
    }

    void Update()
    {
    }
}
