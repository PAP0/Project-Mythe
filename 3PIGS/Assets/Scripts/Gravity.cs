using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public CharacterController controller;

    void Update()
    {
        controller.Move(Physics.gravity * Time.deltaTime);
    }
}
