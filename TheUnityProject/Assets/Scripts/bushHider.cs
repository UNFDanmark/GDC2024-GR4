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

    // Variables added by Daniel
    private bool didPressKey;
    
    void Start()
    {
        material = bushObject.material;
        opacityTimeLeft = opacityTime;
    }
    
    void Update()
    {
        if (isTimeTickingDown)
        {
            if (didPressKey)
            {
                opacityTimeLeft -= Time.deltaTime;
            }
            else
            {
                didPressKey = Input.GetKeyDown(KeyCode.E);
            }
        }
        else
        {
            if (opacityTimeLeft < opacityTime)
            {
                didPressKey = false;
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
