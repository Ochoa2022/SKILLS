using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    public float speed = 10f;
    Vector2 lookDirection = new Vector2(1, 0);
    float horizontal;
    float vertical;
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();
    }

    void Update()
    {   horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);

    }
    void FixedUpdate()
    {
        Vector2 posit = rb2D.position;
        posit.x = posit.x + speed * horizontal * Time.deltaTime;
        posit.y = posit.y + speed * vertical * Time.deltaTime;
        rb2D.MovePosition(posit);
    }
}
