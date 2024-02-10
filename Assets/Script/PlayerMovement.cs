using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float DiagonalModifier;
    Rigidbody rb;
    Vector3 dir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

       if(Input.GetKey(KeyCode.A))
       {
            dir.x = -1;
       }
       else if(Input.GetKey(KeyCode.D))
       {
            dir.x = 1;
       }

       else if(Input.GetKey(KeyCode.S))
       {
            dir.z = -1;
       }
       else if(Input.GetKey(KeyCode.W))
       {
            dir.z = 1;
       }
    }

    void FixedUpdate()
    {
       rb.velocity = new Vector3(dir.x * Speed, dir.z * Speed);
    }
}
