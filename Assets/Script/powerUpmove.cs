using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpmove : MonoBehaviour
{
    public GameObject explosion;
     
    public int scoreValue;
    private GameControler gameController;
    
    
    
    public Rigidbody rb;
    
    void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameControler>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find GameCOntroller script");
        }
    }
   
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(4, 4, 4);
        rb.AddForce(1, 0, 1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boundary" )  
        {
            return;
        }

        if (other.tag == "Enemy")
        {
            return;
        }

       if (other.tag == "shield")
        {
            return;
        } 


        if (other.tag == "Player")
                 {
                     gameController.Addscore (scoreValue);   
                 }
         
        if (other.tag == "bolt2")
                 {
                       Instantiate(explosion, transform.position, transform.rotation); 
                       Destroy(other.gameObject);
                       Destroy(gameObject); 
                 }
        
        gameController.Addscore (scoreValue);
        
     

         
    }
}
