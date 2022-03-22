using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 moove;


    void Update()
    {
        moove.x = Input.GetAxisRaw("Horizontal");
        moove.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", moove.x);
        animator.SetFloat("Vertical", moove.y);
        animator.SetFloat("Speed", moove.sqrMagnitude);
    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + moove * Speed * Time.fixedDeltaTime);


    }

}