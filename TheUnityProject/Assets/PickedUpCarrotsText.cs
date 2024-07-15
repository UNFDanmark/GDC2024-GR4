using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedUpCarrotsText : MonoBehaviour
{
    private TMPro.TMP_Text text;
    private carrotCount carrotStorage;
    void Start()
    {
        text = GetComponent<TMPro.TMP_Text>();
        
        carrotStorage = GetComponent<carrotCount>();
    }
    
    void Update()
    {
        text.text = $"Carrots Collected: {carrotStorage.carrotsCollected}";
    }
}
