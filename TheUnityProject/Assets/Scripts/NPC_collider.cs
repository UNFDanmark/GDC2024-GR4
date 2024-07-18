using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NPC_collider : MonoBehaviour
{
    
    public GameObject[] objectsToActivate;
    public player_movement PlayerMovement;
    
    // Daniel Variabler
    public int currentChatIndexToActivate;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                PlayerMovement.canJump = false;
                if (objectsToActivate[currentChatIndexToActivate] != null)
                {
                    objectsToActivate[currentChatIndexToActivate].SetActive(true);
                }
                else
                {
                    PlayerMovement.canJump = true;
                }
                
            }
        }
    }
}
