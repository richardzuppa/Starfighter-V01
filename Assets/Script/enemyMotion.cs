using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMotion : MonoBehaviour
{

    public float speed;
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;
    public float x;
    public float y;
    public float z;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        x = Random.Range(-100, 100);
        y = Random.Range(-100, 100);
        z = Random.Range(-100, 100);
        speed = Random.Range(-1, -4);
        Debug.Log(speed);

        // Move top/down

              m_Rigidbody.velocity = new Vector3((Random.Range(1, -2)),0,1) * speed;

        // Move Down/top

              // m_Rigidbody.velocity = new Vector3((Random.Range(1, -2)), 0, -1) * speed;

        // Move RIght/Left
             //m_Rigidbody.velocity = new Vector3(-1, 0, (Random.Range(2, -2))) * speed;


        // Move Left/Right

           // m_Rigidbody.velocity = new Vector3(1, 0, (Random.Range(2, -2))) * speed;

    }



    void FixedUpdate()
    {
        // Rotate random
        m_EulerAngleVelocity = new Vector3(x, y, z);

        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
     }
}
