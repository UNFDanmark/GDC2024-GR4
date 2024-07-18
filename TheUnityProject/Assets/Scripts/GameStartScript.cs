using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScript : MonoBehaviour
{
    public GameObject startScreen;
    public player_movement PlayerMovement;
    void Start()
    {
        PlayerMovement.canJump = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startScreen.SetActive(false);
            PlayerMovement.canJump = true;
        }
    }
}
