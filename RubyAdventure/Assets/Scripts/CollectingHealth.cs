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
        HealthSystem controller = other.GetComponent<HealthSystem>();

        if (controller != null && controller.currentHealth < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }

}
