using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb2d;
    public bool vertical;
    public float changeTime = 3.0f;
    float timer;
    int direction = 1;
    Animator animator;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        timer -= Time.deltaTime;


        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        
        Vector2 position = rb2d.position;

        if (vertical)
        {
            position.y = position.y + speed * direction * Time.deltaTime;
        }
        else
        {
            position.x = position.x + speed * direction * Time.deltaTime;
        }


        rb2d.MovePosition(position);

        animator.SetFloat("Move X", 0);
        animator.SetFloat("Move Y", direction);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();


        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
}

