using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform firePosition;
    public float fireSpeed;


    public float spawnWait;
    public float startWait;

     void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {


            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, firePosition.position, firePosition.rotation) as Rigidbody;
            projectileInstance.AddForce(firePosition.forward * fireSpeed);
            yield return new WaitForSeconds(spawnWait);

        }


    }




     /* void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, firePosition.position, firePosition.rotation) as Rigidbody;
            projectileInstance.AddForce(firePosition.forward * fireSpeed);
        }

    }*/
}
