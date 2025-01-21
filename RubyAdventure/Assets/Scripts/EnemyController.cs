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
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector2 position = rb2d.position;
        position.x = position.x + speed * Time.deltaTime;
        rb2d.MovePosition(position);
    }
}
