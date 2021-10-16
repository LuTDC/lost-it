using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    float speed = 5f;
    float movex, movey;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movex = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed*movex, rb.velocity.y);
        movey = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, speed*movey);

        if(rb.velocity.x != 0f || rb.velocity.y != 0f) anim.SetFloat("speed", 1f);
        else anim.SetFloat("speed", 0f);
        anim.SetFloat("MX", rb.velocity.x);
        anim.SetFloat("MY", rb.velocity.y);
    }
}
