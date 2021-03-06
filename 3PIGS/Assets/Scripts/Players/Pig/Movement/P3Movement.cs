using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3Movement : MonoBehaviour
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
        controller.Move(Physics.gravity * Time.deltaTime);
    }

    void FixedUpdate()
    {
    }

    public void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal4");
        float vertical = Input.GetAxisRaw("Vertical4");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }

    void kaas()
    {

    }

    void MoveAnim()
    {
        if (Input.GetAxisRaw("Horizontal4") > 0f || Input.GetAxisRaw("Vertical4") > 0f || Input.GetAxisRaw("Horizontal4") < 0f || Input.GetAxisRaw("Vertical4") < 0f || Input.GetKey(KeyCode.W))
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
        if (Input.GetButton("Blow"))
        {
            anim.SetBool("isPuffing", true);
        }
        if (Input.GetButtonUp("Blow"))
        {
            anim.SetBool("isPuffing", false);
        }
    }

    void AttackAnim()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            anim.SetBool("isAttacking", false);
        }
    }
}
