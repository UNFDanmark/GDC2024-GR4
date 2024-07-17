using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotPickup : MonoBehaviour
{
    public carrotCount playerStorage; 
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
                Destroy(gameObject);
                playerStorage.carrotsCollected += 1;
            }
        }
    }
}
