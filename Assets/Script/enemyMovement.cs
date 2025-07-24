using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb;
    public float t;
    public float speed;
    public float force;

    void Start()
    {


    }

     void FixedUpdate()
    {
         rb.AddTorque(0, 1, 0);
        
        Vector3 f = target.position - transform.position;
        f = f.normalized;
        f = f * force;
        rb.AddForce(f);
         
    }
}
