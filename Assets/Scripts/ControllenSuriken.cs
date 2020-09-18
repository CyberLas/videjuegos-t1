using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllenSuriken : MonoBehaviour
{   
    public GameObject Ninja;
    private Transform NinkaTrans;
    private Rigidbody2D SurikenRB;
    public float SurikenSpeed; 
    public float SurikenLife;
    void Awake()
    {
        SurikenRB = GetComponent<Rigidbody2D>();
        Ninja = GameObject.FindGameObjectWithTag("Ninja");
        NinkaTrans = Ninja.transform;
    }
    void Start()
    {
        if(NinkaTrans.localScale.x > 0)
        {
            SurikenRB.velocity = new Vector2(SurikenSpeed, SurikenRB.velocity.y);
        }
        else{
            SurikenRB.velocity = new Vector2(-SurikenSpeed, SurikenRB.velocity.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, SurikenLife);
    }
}
