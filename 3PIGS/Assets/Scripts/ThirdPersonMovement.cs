using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Animator anim;

    public float speed;
    //public float downforce;
    //public Rigidbody rb;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Update()
    {
        Move();
        MoveAnim();
        BlowAnim();
        AttackAnim();
        controller.Move(Physics.gravity * Time.deltaTime);
    }

    void FixedUpdate()
    {
    }

    public void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal1");
        float vertical = Input.GetAxisRaw("Vertical1");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y ;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }

    void MoveAnim()
    {
        if (Input.GetAxisRaw("Horizontal1") > 0f || Input.GetAxisRaw("Vertical1") > 0f || Input.GetAxisRaw("Horizontal1") < 0f || Input.GetAxisRaw("Vertical1") < 0f)//|| Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    void BlowAnim()
    {
        if (Input.GetButton("Blow"))// || Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isPuffing", true);
        }
        else //(Input.GetButtonUp("Blow"))
        {
            anim.SetBool("isPuffing", false);
        }
    }

    void AttackAnim()
    {
        if (Input.GetButtonDown("Attack") )//|| Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetBool("isAttacking", true);
        }
        else //(Input.GetButtonUp("Attack"))
        {
            anim.SetBool("isAttacking", false);
        }
    }
}
