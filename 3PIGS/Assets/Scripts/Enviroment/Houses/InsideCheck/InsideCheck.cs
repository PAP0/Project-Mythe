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

    public t1 t1s;
    public t2 t2s;
    public t3 t3s;

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
                if (t1s.t1b == true && t2s.t2b == true && t3s.t3b == true)
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == false && P2Health.isDead == false && P3Health.isDead == true)
            {
                if (t1s.t1b == true && t2s.t2b == true)
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == false && P2Health.isDead == true && P3Health.isDead == false)
            {
                if (t1s.t1b == true && t3s.t3b == true)
                {
                    PigWin = true;
                }
            }
            {
            if (P1Health.isDead == true)
                { 
                if (t2s.t2b == true && t3s.t3b == true)
                {
                    PigWin = true;
                }
            }
                }
            if (P1Health.isDead == false && P2Health.isDead == true && P3Health.isDead == true)
            {
                if (collision.tag == "Pig")
                {
                    PigWin = true;
                }
            }
            if (P1Health.isDead == true && P2Health.isDead == true && P3Health.isDead == true )
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
    }

    
}
