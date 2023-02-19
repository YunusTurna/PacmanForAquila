using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{
    public static int sayac;
    public static int highScore = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore = sayac;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Pacman"){
            sayac = sayac + 1;
            gameObject.SetActive(false);
            
        }
    }
}
