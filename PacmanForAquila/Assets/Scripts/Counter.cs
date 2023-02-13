using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counter;
    void Start()
    {
        counter = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "Point : " + Pellets.sayac;
    }
}
