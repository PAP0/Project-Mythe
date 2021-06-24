using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public pighealth pighealth;
    public pighealth pighealth2;
    public pighealth pighealth3;

    //public PigCheck pcheck;

    public bool p1d;
    public bool p2d;
    public bool p3d;

    //public HouseWoodScript wood;
    //public HouseStrawScript straw;
    //public HouseStoneScript stone;

    public GameObject WolfWin;
    public GameObject PigWin;
    public GameObject WolfLose;
    public GameObject PigLose;

    [SerializeField]
    private InsideCheck ICheck;

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
        if (p1d == true && p2d == true && p3d == true)//pighealth.isDead == true && pighealth2.isDead == true && pighealth3.isDead == true)
        {
            PigLose.SetActive(true);
            WolfWin.SetActive(true);
            Debug.Log("Wolf Win");
        }
        if(ICheck.PigWin == true)
        {
            PigWin.SetActive(true);
            WolfLose.SetActive(true);
            Debug.Log("Pig Win");
        }
    }
}
