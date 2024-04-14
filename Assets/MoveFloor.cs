using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 tempPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempPos=transform.position;
        tempPos=new Vector3(transform.position.x+0.1f,transform.position.y,transform.position.z);
        transform.position=tempPos;
    }
}
