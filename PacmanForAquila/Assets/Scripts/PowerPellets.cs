using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellets : MonoBehaviour
{
    public static bool isAnim = false;
    private void Start()
    {
        
    }
    
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Pacman")
        {
            Pellets.sayac = Pellets.sayac + 100;
            gameObject.SetActive(false);
            Ai_Movements._anim.SetBool("PowerPellets", true);
            isAnim = true;
        }
        else
        {
            Ai_Movements._anim.SetBool("PowerPellets", false);
            isAnim = false;
        }
    }
}
