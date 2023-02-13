using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    [SerializeField] GameObject pacman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) == true){
            pacman.transform.rotation = Quaternion.Euler(0,0,0);

        }
        if(Input.GetKeyDown(KeyCode.RightArrow) == true){
            pacman.transform.rotation = Quaternion.Euler(0,0,180);
            
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) == true){
            pacman.transform.rotation = Quaternion.Euler(0,0,-90);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) == true){
            pacman.transform.rotation = Quaternion.Euler(0,0,90);
        }
    }
}
