using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerZombie : MonoBehaviour
{
    public GameObject Player;
    private Transform _transform;
    private float gg = 0f;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    void Start()
    {
        _transform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        gg = Player.transform.position.x ;
        
    }

    void Update()
    {
        _transform.position = new Vector3(gg , _transform.position.y, _transform.position.z );
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if((other.gameObject.tag == "Suriken")) {
            animator.SetInteger("Dead", 1);
        }
    }

}
