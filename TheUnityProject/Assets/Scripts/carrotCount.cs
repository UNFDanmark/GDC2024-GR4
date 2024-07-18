using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotCount : MonoBehaviour
{
    public int carrotsCollected = 0;
    public NPC_collider NpcCollider;
    public NPC_collider CottageCollider;
    public bool AllowEnteringCottage;
    
    void Start()
    {
    }
    
    void Update()
    {
        if (carrotsCollected < 5)
        {
            NpcCollider.currentChatIndexToActivate = 1;
            if (AllowEnteringCottage)
            {
                CottageCollider.currentChatIndexToActivate = 1;
            }
        }
        else
        {
            NpcCollider.currentChatIndexToActivate = 2;
            if (AllowEnteringCottage)
            {
                CottageCollider.currentChatIndexToActivate = 2;
            }
        }
    }
}
