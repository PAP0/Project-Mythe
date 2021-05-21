using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigInventoru : MonoBehaviour
{
    public int AmountStraw;
    public int AmountWood;
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
                AmountStraw = AmountStraw + 1;
            Debug.Log(AmountStraw);

        }
        if (collision.tag == "Wood")
        {
            Debug.Log("touching");
                Destroy(GameObject.FindWithTag("Wood"));
                AmountWood = AmountWood + 1;
                Debug.Log(AmountWood);
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


}
