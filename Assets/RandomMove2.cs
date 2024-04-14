using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove2 : MonoBehaviour
{
    public GameObject player;
    private float limit=37;//represents off screen
    Vector3 tempPos;
    // Start is called before the first frame update
    void Start()
    {
        limit+=player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x> limit){//When the object goes off screen, moves the object to random x and y cordinate.
            tempPos=transform.position;
            tempPos=new Vector3(transform.position.x+37f,transform.position.y+Random.Range(0f,3.0f),transform.position.z);
             
            transform.position=tempPos;
            limit+=30;
        }
    }
}
