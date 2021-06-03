using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float GravitySpeed = -0.03f;
    public bool GravityCheck = false;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Terrain")
        {
            GravityCheck = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        GravityCheck = false;
    }

    void Update()
    {
        transform.Translate(0, GravitySpeed, 0);
        if (GravityCheck == false)
        {
        }
    }
}
