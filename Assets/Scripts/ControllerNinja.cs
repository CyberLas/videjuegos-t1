using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerNinja : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    private int muerte = 0;
    
    public Transform KunaiSpawner;
    public GameObject  KunaiPrefab;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Kunai();
        rb.velocity = new Vector2(0,rb.velocity.y);
        animator.SetInteger("Run", 0);
        animator.SetInteger("Jump", 0);

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if(muerte == 0)
            {
                rb.velocity = new Vector2(10, rb.velocity.y);
                sr.flipX = false;
                animator.SetInteger("Run", 1);
            }
        }

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if(muerte == 0)
            {
                rb.velocity = new Vector2(-10, rb.velocity.y);
                sr.flipX = true;
                animator.SetInteger("Run", 1);
            }
        }
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if(muerte == 0)
            {
                rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
                animator.SetInteger("Jump", 1);
            }
        }
        if(Input.GetKey(KeyCode.Space))
        {
            if(muerte == 0)
            {
               
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if((other.gameObject.tag == "Zombie")) {
            animator.SetInteger("Dead", 1);
            muerte = 1;
        }
    }
    public void Kunai()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(KunaiPrefab, KunaiSpawner.position, KunaiSpawner.rotation);
        }
    }
}
