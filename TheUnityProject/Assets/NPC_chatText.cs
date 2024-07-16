using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_chatText : MonoBehaviour
{
    public string[] NPC_chatten;
    private int chatIndex = 0;
    public TMPro.TMP_Text chatBoxText;
    public GameObject[] objectsToActivate;
    public GameObject objectToDeactivate;
    public player_movement PlayerMovement;
    void Start()
    {
        chatBoxText.text = NPC_chatten[chatIndex];
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (chatIndex < (NPC_chatten.Length - 1)){
                chatIndex += 1;
                chatBoxText.text = NPC_chatten[chatIndex];
            }
            else
            {
                objectToDeactivate.SetActive(false);
                PlayerMovement.canJump = true;
                foreach (var GameObject in objectsToActivate)
                {
                    GameObject.SetActive(true);
                }
            }
        }
        
    }
}
