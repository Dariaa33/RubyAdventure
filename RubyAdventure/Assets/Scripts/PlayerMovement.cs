using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public InputAction MoveAction;
    Rigidbody2D rb2D;
    Vector2 move;
    [SerializeField]
    float speed = 0.1f;

    void Start()
    {
        MoveAction.Enable();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
     
    }

    private void FixedUpdate()
    {
        Vector2 position = (Vector2)rb2D.position + move * 3.0f * Time.deltaTime * speed;
        rb2D.MovePosition(position);
    }
}
