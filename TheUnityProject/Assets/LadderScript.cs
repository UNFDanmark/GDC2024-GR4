using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private bool canJump;
    void Update()
    {
        canJump = Input.GetKey(KeyCode.Space);
    }

    private void OnTriggerStay(Collider other)
    {
        if (canJump)
        {
            if (other.CompareTag("Player"))
            {
                Rigidbody body = other.GetComponent<Rigidbody>();
                body.AddForce(Vector3.up*10f, ForceMode.Force);
            }
            canJump = false;
        }
    }
}
