using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioZone : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _audioSource.volume = 1;
    }
    
    private void OnTriggerExit(Collider other)
    {
        _audioSource.volume = 0;
    }
}
