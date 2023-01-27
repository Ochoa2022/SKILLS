using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class en: MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rb2D;
    public float change = 2.0f;
    float timer;
   public int direction = 1;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        timer = change;

    }
    void Update()
    {   timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = direction * -1;
            timer = change;
        }

    }
    


void FixedUpdate()
    {
        Vector2 posi = rb2D.position;
        posi.x = posi.x + Time.deltaTime * speed * direction;
        rb2D.MovePosition(posi);
    }
}
