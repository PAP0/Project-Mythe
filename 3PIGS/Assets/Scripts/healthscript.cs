using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthscript : MonoBehaviour
{
    public float health;
    public float damageamount;

    public void takeDamage()
    {
        health -= damageamount;
    }

    void Update()
    {
        if (health <= 1)
        {
            Debug.Log("dedded");
        }
    }

}
