using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 20;
    public new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //Pega o componente ao iniciar o jogo
        rigidbody = GetComponent<Rigidbody>();
        
        //Jeito errado: it will rotate the astroid locally causing it to move all over the 3 axis *globally*
        //rigidbody.velocity = transform.forward * speed;

        //Jeito correto: to move the asteroid along the global Z axis
        rigidbody.velocity = Vector3.forward * speed;
    }
}
