using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMotion_b : MonoBehaviour
{

    public float speed_b;
    Rigidbody m_Rigidbody_b;
    Vector3 m_EulerAngleVelocity_b;
    public float x_b;
    public float y_b;
    public float z_b;
    void Start()
    {
        m_Rigidbody_b = GetComponent<Rigidbody>();
        x_b = Random.Range(-100, 100);
        y_b = Random.Range(-100, 100);
        z_b = Random.Range(-100, 100);
        speed_b = Random.Range(-1, -4);

        // Move top/down


        m_Rigidbody_b.velocity = new Vector3((Random.Range(1, -2)), 0, -1) * speed_b;

        m_Rigidbody_b.transform.localScale = new Vector3 ((Random.Range(0.2f, 1.0f)), (Random.Range(0.2f, 1.0f)), (Random.Range(0.2f, 1.0f)));

    }



    void FixedUpdate()
    {
        // Rotate random
        m_EulerAngleVelocity_b = new Vector3(x_b, y_b, z_b);

       Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity_b * Time.fixedDeltaTime);
        m_Rigidbody_b.MoveRotation(m_Rigidbody_b.rotation * deltaRotation);
     }
}
