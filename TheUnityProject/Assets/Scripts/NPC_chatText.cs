using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_chatText : MonoBehaviour
{
    public string[] NPC_chatten;
    private int chatIndex = 0;
    public TMPro.TMP_Text chatBoxText;
    public RawImage chatAvatarImage;
    public GameObject[] objectsToActivate;
    public GameObject objectToDeactivate;
    public player_movement PlayerMovement;
    
    // Daniel lavet variable
    public Texture[] NPC_textures;
    public GameObject mouseToShowInScene;
    public Texture mouseUITexture;
    public carrotCount playerStorage;
    
    void Start()
    {
        chatBoxText.text = NPC_chatten[chatIndex];
        chatAvatarImage.texture = NPC_textures[chatIndex];
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (chatIndex < (NPC_chatten.Length - 1)){
                chatIndex += 1;
                chatBoxText.text = NPC_chatten[chatIndex];
                chatAvatarImage.texture = NPC_textures[chatIndex];

                if (chatAvatarImage.texture == mouseUITexture)
                {
                    // Åbn cottage her, da når man ser musen er det ok at gå i cottage
                    mouseToShowInScene.SetActive(true);
                    playerStorage.AllowEnteringCottage = true;
                }
            }
            else
            {
                // Reset
                chatIndex = 0;
                chatBoxText.text = NPC_chatten[chatIndex];
                chatAvatarImage.texture = NPC_textures[chatIndex];
                
                // Reactivate after
                objectToDeactivate.SetActive(false);
                PlayerMovement.canJump = true;
                foreach (var GameObject in objectsToActivate)
                {
                    if (GameObject != null)
                    {
                        GameObject.SetActive(true);
                    }
                }
            }
        }
        
    }
}
