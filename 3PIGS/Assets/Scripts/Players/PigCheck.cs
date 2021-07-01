using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigCheck : MonoBehaviour
{
    public pighealth pighealth;
    public pighealth pighealth2;
    public pighealth pighealth3;

    public bool p1d;
    public bool p2d;
    public bool p3d;
    void Start()
    {
        p1d = false;
        p2d = false;
        p3d = false;
    }

    void Update()
    {
        if (pighealth.isDead == true)
        {
            p1d = true;
        }
        if (pighealth2.isDead == true)
        {
            p2d = true;
        }
        if (pighealth3.isDead == true)
        {
            p3d = true;
        }
    }
}
