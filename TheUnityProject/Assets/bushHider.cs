using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushnHider : MonoBehaviour
{
    public float opacityTime = 3;
    private float opacityTimeLeft;
    public MeshRenderer bushObject;
    private bool isTimeTickingDown = false;
    private Material material;
    void Start()
    {
        material = bushObject.material;
        opacityTimeLeft = opacityTime;
    }
    
    void Update()
    {
        if (isTimeTickingDown)
        {
            opacityTimeLeft -= Time.deltaTime;
        }
        else
        {
            if (opacityTimeLeft < opacityTime)
            {
                opacityTimeLeft += Time.deltaTime;
            }
           
        }
            
        if (opacityTimeLeft < 0)
        {
            opacityTimeLeft = 0;
            
        }

        var color = material.color;
        color.a = opacityTimeLeft / opacityTime;
        material.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTimeTickingDown = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTimeTickingDown = false;
        }
    }
}
