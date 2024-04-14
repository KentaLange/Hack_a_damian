using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunshineMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;//rigid body 
    private float speed=3f;
    public float timeS;
    public GameObject bascketball1;
    public GameObject bascketball2;
    private int count=0;
    
   // public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed<6){
            speed+=0.01f;
        }
       
    //horizontal=Input.GetAxisRaw("Horizontal");
      rb.velocity=new Vector2( speed, rb.velocity.y);//move horizontal
    }

    /*private void OnCollisionEnter2D(Collision2D other){//If u correct bascketball, move the ball to random location.
      if(other.gameObject.CompareTag("BB")){
         speed--;
         print("aa");
         bascketball1.SetActive(false);
        // bascketball1.transform.position=new Vector3(Random.Range(50.0f,60.0f), Random.Range(-3.68f,1.0f),0);
         //count++;
      }

      if(other.gameObject.CompareTag("BB") ){
         speed--;
         print("aa");
         bascketball2.SetActive(false);
         //bascketball2.transform.position=new Vector3(Random.Range(70.0f,80.0f), Random.Range(-3.68f,1.0f),0);
         //count++;
      }
      
    }*/
}
