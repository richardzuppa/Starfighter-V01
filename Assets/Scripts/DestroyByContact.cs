using UnityEngine;

public class DestroyByContact : MonoBehaviour
{


    public GameObject explosion;
    public GameObject playerExplosion;

    public int scoreValue;
    private GameControler gameController;

    private Healthbar healthbar;

    void Start ()
    {
        GameObject healthbarObject = GameObject.FindWithTag ("healthbg");
        if (healthbarObject != null)
        {
            healthbar = healthbarObject.GetComponent <Healthbar>();
        }
        
        
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
                       Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
                 }
        Instantiate(explosion, transform.position, transform.rotation);
        gameController.Addscore (scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
     

         
    }
}
