using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class DamageZone : MonoBehaviour
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

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {

    }
}
