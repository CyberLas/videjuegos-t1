using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerZombie : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    int seguir = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
         
    }

    void Update()
    {
        rb.velocity = new Vector2(0,rb.velocity.y);

        if(seguir == 0){
            rb.velocity = new Vector2(-1, rb.velocity.y);
            sr.flipX = true;
        }else{
            rb.velocity = new Vector2(1, rb.velocity.y);
            sr.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if((other.gameObject.tag == "Suriken")) {
            animator.SetInteger("Dead", 1);
            seguir = 0;
        }
    }

}
