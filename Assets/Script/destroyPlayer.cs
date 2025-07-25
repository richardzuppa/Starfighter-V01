using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlayer : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public GameObject shield;
    private bool shieldActive;

    public AudioSource source;
    public AudioClip healthSound;

    private Healthbar healthbar;

    private void Start()
    {
        GameObject healthbarObject = GameObject.FindWithTag ("healthbg");
        if (healthbarObject != null)
        {
            healthbar = healthbarObject.GetComponent <Healthbar>();
        }

        shield.SetActive(false);
    }


    // SHIELD

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shield.SetActive(true);
            shieldActive = true;
            healthbar.DimHealth();
        }
        else shield.SetActive(false);

    }
    // SHIELD

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "powerup" )  
        {
            source.PlayOneShot(healthSound);
            Destroy(other.gameObject);
            healthbar.SumHealth();
            
        }

        if ((other.tag == "shield") || (other.tag == "boundary") || (other.tag == "powerup" ))
        {
            return;
        }

        
        if (other.tag == "BoltEnemy")  
        {
            
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(other.gameObject);
        if( shieldActive)
        { 
            return;
        }
        Destroy(gameObject);
         
    }
}
