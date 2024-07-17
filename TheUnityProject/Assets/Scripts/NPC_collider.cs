using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_collider : MonoBehaviour
{
    
    public GameObject objectToActivate;
    public player_movement PlayerMovement;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                PlayerMovement.canJump = false;
                objectToActivate.SetActive(true);
                
            }
        }
    }
}
