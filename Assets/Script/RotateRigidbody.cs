using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public class RotateRigidbody : MonoBehaviour
{
    // ROTATE RIGIDBODY

    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;
    public float amount;

    public float xMin, xMax, zMin, zMax;

     


    // MOVE
     
    public float move_amount;
    public GameObject shield;
    public GameObject engine;
    //public Transform shieldPosition;

    void Start()
    {
         
        shield.SetActive(false);
        
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
      
        m_Rigidbody.AddForce(0, 0, 100);
    }

    void FixedUpdate()
    {
        // ROTATE

        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;


        m_EulerAngleVelocity = new Vector3(0, h, 0);

        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);

        
       

            




        // MOVE

        if (Input.GetKey("up"))
        {
            engine.SetActive(true);
             

        }
        else engine.SetActive(false);

            if (Input.GetKey("up"))
            m_Rigidbody.AddForce(transform.forward * move_amount);
            
        else if (Input.GetKey("down"))
            m_Rigidbody.AddForce(0, 0, -10);

        m_Rigidbody.position = new Vector3
            (
                Mathf.Clamp (m_Rigidbody.position.x, xMin, xMax),
                0.0f,
                Mathf.Clamp (m_Rigidbody.position.z, zMin, zMax)

            );

        
    }   
}