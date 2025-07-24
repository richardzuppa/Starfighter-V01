using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMotion_t : MonoBehaviour
{

    public float speed_t;
    Rigidbody m_Rigidbody_t;
    Vector3 m_EulerAngleVelocity_t;
    public float x_t;
    public float y_t;
    public float z_t;
    void Start()
    {
        m_Rigidbody_t = GetComponent<Rigidbody>();
        x_t = Random.Range(-100, 100);
        y_t = Random.Range(-100, 100);
        z_t = Random.Range(-100, 100);
        speed_t = Random.Range(-1, -4);

        // Move top/down


        m_Rigidbody_t.velocity = new Vector3((Random.Range(1, -2)), 0, 1) * speed_t;

        m_Rigidbody_t.transform.localScale = new Vector3 ((Random.Range(0.2f, 1.0f)), (Random.Range(0.2f, 1.0f)), (Random.Range(0.2f, 1.0f)));

    }



    void FixedUpdate()
    {
        // Rotate random
        m_EulerAngleVelocity_t = new Vector3(x_t, y_t, z_t);

       Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity_t * Time.fixedDeltaTime);
        m_Rigidbody_t.MoveRotation(m_Rigidbody_t.rotation * deltaRotation);
     }
}
