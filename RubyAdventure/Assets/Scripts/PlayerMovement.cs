using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public InputAction LeftAction;
    public InputAction MoveAction;
    float speed = 0.1f;

    /*float horizontal = 0.0f;
    float vertical = 0.0f;
    [SerializeField]
    */
    void Start()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + move * 0.1f * speed;
        transform.position = position;

        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            horizontal = -1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            horizontal = 1.0f;
        }
      

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vertical = -1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vertical = 1.0f;
        }
       

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal * speed;
        position.y = position.y + 0.1f * vertical * speed;
        transform.position = position;*/


    }
}
