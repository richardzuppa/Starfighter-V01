using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;



    void OnTriggerEnter(Collider other)
    {
       




        if (other.tag == "boundary")
        {
            return;
        }

        if (other.tag == "Asteroid 1")
        {
            return;
        }

        if (other.tag == "Asteroid 2")
        {
            return;
        }

        if (other.tag == "shield")
        {
            return;
        }

        if (other.tag == "bolt1")
        {
            return;
        }

        if (other.tag == "Player")
        {
            
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
