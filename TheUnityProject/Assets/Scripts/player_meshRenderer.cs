using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_meshRenderer : MonoBehaviour
{
    
   
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        float colour = meshRenderer.material.color.a;
    }
    
    void Update()
    {
        
    }
    
}
