using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_chatText : MonoBehaviour
{
    public string[] NPC_chatten;
    private int chatIndex = 0;
    public TMPro.TMP_Text chatBoxText;
    void Start()
    {
        chatBoxText.text = NPC_chatten[chatIndex];
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            chatIndex += 1;
            chatBoxText.text = NPC_chatten[chatIndex];
        }
        
    }
}
