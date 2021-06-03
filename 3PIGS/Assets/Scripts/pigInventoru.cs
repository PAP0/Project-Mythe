using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigInventoru : MonoBehaviour
{
    public int AmountStraw;
    public int AmountWood;
    public int AmountStone;
    public int AddStraw;
    public int AddWood;
    public int AddStone;
    public int Amount;


    

    // Use this for initialization
    void Start()
    {
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == "Straw")
        {
            Debug.Log("touching");
                Destroy(GameObject.FindWithTag("Straw"));
                AmountStraw = AmountStraw + AddStraw;
            Debug.Log(AmountStraw);

        }
        if (collision.tag == "Wood")
        {
            Debug.Log("touching");
                Destroy(GameObject.FindWithTag("Wood"));
                AmountWood = AmountWood + AddWood;
                Debug.Log(AmountWood);
        }
        if (collision.tag == "Stone")
        {
            Debug.Log("touching");
            Destroy(GameObject.FindWithTag("Stone"));
            AmountStone = AmountStone + AddStone;
            Debug.Log(AmountStone);
        }
    }

    void BuildHouse()
    {
    }

    public void RemoveStraw()
    {
        AmountStraw = AmountStraw - 1;
    }

    public void RemoveWood()
    {
        AmountWood = AmountWood - 1;
    }
    public void RemoveStone()
    {
        AmountStone = AmountStone - 1;
    }


}
