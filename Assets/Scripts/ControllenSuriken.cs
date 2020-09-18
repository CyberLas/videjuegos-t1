using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllenSuriken : MonoBehaviour
{
    private Rigidbody2D SurikenRB;
    public float SurikenSpeed; 

    void Awake()
    {
        SurikenRB = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        SurikenRB.velocity = new Vector2(SurikenSpeed, SurikenRB.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
