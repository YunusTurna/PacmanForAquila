using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float movement;
    private bool yatayP;

    Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        speed = 50f;
        movement = 1;
    }

    private void Update() {
        Yatay();
        
    }

    private void Yatay(){
        rb.velocity = new Vector2(movement * speed , 0);
        if(Input.GetKeyDown(KeyCode.LeftArrow) == true){
            movement = -1;

        }
        else{
            movement = 1;
        }

        

        

    }



}
