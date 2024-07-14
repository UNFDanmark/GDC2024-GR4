using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinHider : MonoBehaviour
{
    public GameObject coinObject;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinObject.SetActive(true);
        }
    }
}
