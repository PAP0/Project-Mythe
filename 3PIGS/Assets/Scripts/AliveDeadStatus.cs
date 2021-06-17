using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveDeadStatus : MonoBehaviour
{
    public pighealth pighealth;
    public pighealth pighealth2;
    public pighealth pighealth3;

    public GameObject pigAlive;
    public GameObject pigAlive2;
    public GameObject pigAlive3;

    public GameObject pigDead;
    public GameObject pigDead2;
    public GameObject pigDead3;

    void Start() {
        pigDead.SetActive(false);
        pigDead2.SetActive(false);
        pigDead3.SetActive(false);

    }


    void Update()
    {
        if(pighealth.isDead == true)
        {
            pigDead.SetActive(true);
            pigAlive.SetActive(false);
        }

        if(pighealth2.isDead == true)
        {
            pigDead2.SetActive(true);
            pigAlive2.SetActive(false);
        }

        if(pighealth3.isDead == true)
        {
            pigDead3.SetActive(true);
            pigAlive3.SetActive(false);
        }
    }
}