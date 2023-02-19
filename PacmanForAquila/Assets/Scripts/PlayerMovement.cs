using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  Rigidbody2D rb;

  [SerializeField] GameObject pacman;
  [SerializeField] GameObject spawnPoint;

  Vector3 spawnPointLocation;
  
  private int movementH , movementV;
  private int speed;
  private bool isRight = true;
  private bool isUp = true;

  private bool horizontal = true;
  public static int health = 3;
  


  

  


  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    movementH = 1;
    movementV = 1;
    speed = 5;
    spawnPointLocation= spawnPoint.transform.position;
  }
  
  
  
  
  
  private void Update() {
    if(horizontal == true){
        HorizontalMovement();
        if(Input.GetKey(KeyCode.UpArrow) == true || Input.GetKey(KeyCode.DownArrow) == true){
            horizontal = false;

        }


    }
    else{
        VerticalMovement();
        if(Input.GetKey(KeyCode.LeftArrow) == true || Input.GetKey(KeyCode.RightArrow) == true){
            horizontal = true;
        }
    }

    

    
    
    
  }


  private void HorizontalMovement(){
    rb.velocity = new Vector2(movementH * speed , 0);



    
    
      if(isRight == true){
        movementH = 1;
        
        if(Input.GetKey(KeyCode.LeftArrow) == true){
            isRight = false;
            movementH = -1;
            
        }
      }
      else{
        movementH = -1;
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            movementH = 1;
            
        }
      } 

  }
  private void VerticalMovement(){
    rb.velocity = new Vector2(0 , movementV * speed);
    
    
      if(isUp == true)
      {
        movementV = 1;
        
        if(Input.GetKey(KeyCode.DownArrow) == true){
            isUp = false;
            movementV = -1;
        }
      }
      else{
        movementV = -1;
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            isUp = true;
            movementV = 1;
        }
      }

      
      }


  
  
  private void OnCollisionEnter2D(Collision2D other)
   {
        if(other.gameObject.tag == "Enemy")
        {
          Destroy(gameObject);
          health = health - 1;
          
          Instantiate(pacman , spawnPointLocation , Quaternion.identity);
          
        }
   }

   IEnumerator Wait()
   {
    yield return new WaitForSeconds(3);
   }
}
