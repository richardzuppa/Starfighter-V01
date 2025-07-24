using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    
    // ADD TORQUE
    
    public float amount = 1f;

    void FixedUpdate ()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

         GetComponent<Rigidbody>().AddTorque(transform.up * h, ForceMode.VelocityChange);
         GetComponent<Rigidbody>().AddTorque(transform.right * v, ForceMode.VelocityChange);

         
    }
}

// ADD TORQUE FIM


