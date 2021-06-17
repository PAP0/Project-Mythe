using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideCheck : MonoBehaviour
{
    [SerializeField]
    private pighealth P1Health;
    [SerializeField]
    private pighealth P2Health;
    [SerializeField]
    private pighealth P3Health;

    [SerializeField]
    private HouseStoneScript HouseStone;

    public bool PigWin;

    void Update()
    {
    }
    void OnTriggerStay(Collider collision)
    {
        #region if statements
        if (HouseStone.isDone == true)
        {
            if (P1Health.isDead == false && P2Health.isDead == false && P3Health.isDead == false)
            {
                if (collision.tag == "Pig" && collision.tag == "Pig2" && collision.tag == "Pig3")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == false && P2Health.isDead == false && P3Health.isDead == true)
            {
                if (collision.tag == "Pig" && collision.tag == "Pig2")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == false && P2Health.isDead == true && P3Health.isDead == false)
            {
                if (collision.tag == "Pig" && collision.tag == "Pig3")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == true && P2Health.isDead == false && P3Health.isDead == false)
            {
                if (collision.tag == "Pig2" && collision.tag == "Pig3")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == false && P2Health.isDead == true && P3Health.isDead == true)
            {
                if (collision.tag == "Pig")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == true && P2Health.isDead == false && P3Health.isDead == true)
            {
                if (collision.tag == "Pig2")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == true && P2Health.isDead == true && P3Health.isDead == false)
            {
                if (collision.tag == "Pig3")
                {
                    PigWin = true;
                }
            }
        }
        #endregion
        //if (collision.tag == "Pig")
    }

    public void Check()
    {

    }
}
