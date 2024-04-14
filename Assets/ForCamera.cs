using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCamera : MonoBehaviour
{
     
    public Transform target;
    private Vector3 offset;
    public float dumping;
    private Vector3 velocity=Vector3.zero;
    
    [SerializeField] private Rigidbody2D rb;//rigid body 
    private float speed=6.5f;
    //private float BackSpeed=12f;
    private float horizontal;
    AudioSource aud;
    //var VP;
    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        aud=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //tempPos=transform.position;
        //tempPos=new Vector3(transform.position.x+37f,transform.position.y+Random.Range(0f,3.0f),transform.position.z);
        horizontal=Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2( speed*horizontal, rb.velocity.y);//move horizontal
        
        
    }

    /*void FixedUpdate(){
        Vector3 movePosition=target.position + offset;
        transform.position=Vector3.SmoothDamp(transform.position, movePosition,ref velocity,dumping);
    }*/
}
