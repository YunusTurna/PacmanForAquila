using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hearth : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "Health" + PlayerMovement.health;
    }
}
