using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    
    // Rotate sem rigidbody
    
    
    public Vector3 rotation;
    public float speed_r;
    public float amount;


    void Update ()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;


        rotation=new Vector3(0, h, 0);

        transform.Rotate(rotation * speed_r * Time.deltaTime);
    }
}
