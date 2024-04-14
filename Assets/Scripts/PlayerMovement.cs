using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
  [SerializeField] private Rigidbody2D rb;//rigid body 
  [SerializeField] private Transform groundCheck ;
  //[SerializeField] private LayerMask groundLayer ;
   private float horizontal;
   private float speed=8f;
   private float Jump=20f;
   public bool update;
   public int frame;
    

    // Update is called once per frame
    void Update()
    {
      
      
      horizontal=Input.GetAxisRaw("Horizontal");
      rb.velocity=new Vector2(horizontal * speed, rb.velocity.y);//move horizontal
      
      if(update){//When the player lands on ground, give 10f of window for high jump.
        
        frame=10;
      }
        if(frame>0){
          
          rb.velocity=new Vector2(rb.velocity.x,10f); 
          if(Input.GetKeyDown("space")){//If I'm on the ground and press jump, jump
           
            rb.velocity=new Vector2(rb.velocity.x,Jump);
            //rb.AddForce(new Vector2(rb.velocity.x, 100f));
            
            
            frame=-1;
         }

          frame--;
        }

        
        
      
      
    }

    
   

    private void OnCollisionEnter2D(Collision2D other){
      if(other.gameObject.CompareTag("Floor")){
        
       // Vector3 normal=other.GetContact(0).normal;
        //if(normal == Vector3.up){
            update=true;
        //}
        
      }

      
    }

    private void OnCollisionExit2D(Collision2D other){
      if(other.gameObject.CompareTag("Floor")){
         update=false;
      }
      
    }
    
}
