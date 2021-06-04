using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public pighealth pighealth;
    public pighealth pighealth2;
    public pighealth pighealth3;
    public HouseWoodScript wood;
    public HouseStrawScript straw;
    public HouseStoneScript stone;

    public GameObject WolfWin;
    public GameObject PigWin;
    public GameObject WolfLose;
    public GameObject PigLose;

    void Update()
    {
        if(pighealth.isDead == true && pighealth2.isDead == true && pighealth3.isDead == true)
        {
            PigLose.SetActive(true);
            WolfWin.SetActive(true);
            Debug.Log("Wolf Win");
        }
        if(wood.isDone == true && straw.isDone == true && stone.isDone == true)
        {
            PigWin.SetActive(true);
            WolfLose.SetActive(true);
            Debug.Log("Pig Win");
        }
    }
}
