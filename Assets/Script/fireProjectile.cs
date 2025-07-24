using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireProjectile : MonoBehaviour
{ 



    public Rigidbody projectile;
    public Transform firePosition;
    public float fireSpeed;
  

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, firePosition.position, firePosition.rotation) as Rigidbody;
            projectileInstance.AddForce(firePosition.forward * fireSpeed);
        }
    
    }
}
