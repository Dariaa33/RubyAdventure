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
    public int maxHealth = 3;
    public int health { get { return currentHealth; } }
    public int currentHealth;
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float damageCooldown;
    void Start()
    {
        MoveAction.Enable();
        rb2D = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();

        if (isInvincible)
        {
            damageCooldown -= Time.deltaTime;
            if (damageCooldown < 0)
            {
                isInvincible = false;
            }
        }

    }

    private void FixedUpdate()
    {
        Vector2 position = (Vector2)rb2D.position + move * 3.0f * Time.deltaTime * speed;
        rb2D.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
            {
                return;
            }
            isInvincible = true;
            damageCooldown = timeInvincible;
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
