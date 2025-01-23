using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingHealth : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement controller = other.GetComponent<PlayerMovement>();

        if (controller != null && controller.currentHealth < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }

}
