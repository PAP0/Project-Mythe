using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public pighealth pighealth;
    public pighealth pighealth2;
    public pighealth pighealth3;

    public bool p1d;
    public bool p2d;
    public bool p3d;

    public GameObject WolfWin;
    public GameObject PigWin;

    [SerializeField]
    private InsideCheck ICheck;

    void Start()
    {
        p1d = false;
        p2d = false;
        p3d = false;
        WolfWin.SetActive(false);
        PigWin.SetActive(false);
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
        if (p1d == true && p2d == true && p3d == true)
        {
            WolfWin.SetActive(true);
        }
        if(ICheck.PigWin == true)
        {
            PigWin.SetActive(true);
        }
    }
}
