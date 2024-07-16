using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_startScript : MonoBehaviour
{
    public GameObject startScreen; 
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startScreen.SetActive(false);
            print("Startscreen = false");
        }
    }
}
