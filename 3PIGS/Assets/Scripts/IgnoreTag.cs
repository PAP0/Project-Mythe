using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTag : MonoBehaviour
{
    public Collider cd;

    private void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Pig")
            {
                Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
            }
        }
}
