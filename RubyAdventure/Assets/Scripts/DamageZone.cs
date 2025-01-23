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
        PlayerMovement controller = other.GetComponent<PlayerMovement>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

}
