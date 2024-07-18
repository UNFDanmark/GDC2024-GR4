using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotPickup : MonoBehaviour
{
    public carrotCount playerStorage; 
    
    // Daniel har skrevet nedstående variable
    public bool willBeAllowedToInteract = true;
    bool isAllowedToInteract;
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
            if (Input.GetKey(KeyCode.E) && isAllowedToInteract)
            {
                Destroy(gameObject);
                playerStorage.carrotsCollected += 1;
                playerStorage.PlayCollectSound();
            }
        }

        // Hvis man ikke holder knappen inde så kan den tillade at interact
        if (!Input.GetKey(KeyCode.E))
        {
            isAllowedToInteract = willBeAllowedToInteract;
        }
    }
}
