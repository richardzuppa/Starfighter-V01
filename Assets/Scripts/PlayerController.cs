using System;
using UnityEngine;


//[Serializable]
//public class Boundary
//{
//    //atributos mínimos e máximos dos limites de visão da tela
//    public float xMin, xMax, zMin, zMax;
//}

public class PlayerController : MonoBehaviour
{
    ////inclinação da nave
    //public float tilt = 4;
    ////velocidade dos movimentos
    //public float speed = 10;
    ////limites da tela
    //public Boundary boundary;

    ////pega o objeto transform do Spawn
    //public Transform shotSpawn;
    ////pega o objeto transofrm do tiro
    //public Transform shot;
    //[SerializeField]
    //private new AudioSource audio;

    ////taxa de tiros por tempo
    //[SerializeField]
    //private float fireRate = 0.25f;

    ////corpo rígido da nave
    //private new Rigidbody rigidbody;
    
    ////verifica o próximo tiro
    //private float nextFire;

    //void Start()
    //{
    //    //assim que o jogo inicia, pega o corpo rígido da nave
    //    //e armazena em variável
    //    rigidbody = GetComponent<Rigidbody>();
    //}

    //void FixedUpdate()
    //{
    //    //a cada frame pega a movimentação horizontal e vertical
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");

    //    //armazena os movimentos horizontais e verticais em um Vector3
    //    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
    //    //multiplica movimentos por uma variável e aplica na velocidade da nave 
    //    rigidbody.velocity = movement * speed;
        
    //    //realiza cálculo matemático para limitar a nave na área de visão da tela
    //    rigidbody.position = new Vector3
    //    (
    //        Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
    //        0.0f,
    //        Mathf.Clamp(rigidbody.position.z, boundary.zMin, boundary.zMax)
    //    );

    //    //utilizando os quaternions de Euler, inclina a nave contra o seu eixo de rotação
    //    rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
    //}

    //private void Update()
    //{
    //    //verifica se o gamer apertou o botão esquerdo do mouse ou a tecla space e
    //    //o tempo atual desde o início do primeiro frame do jogo é maior que próximo disparo
    //    if ((Input.GetButton("Fire1") || Input.GetKey(KeyCode.Space)) && Time.time > nextFire)
    //    {
    //        //incrementa o tempo de disparo ao frame atual e atribui ao próximo disparo
    //        nextFire = Time.time + fireRate;
    //        //Debug.Log(nextFire + " e " + Time.time);
    //        //instancia o tiro na posição e rotação pré-definidas na cena do jogo
    //        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    //        //Toca o áudio dos tiros
    //        audio.Play();
    //    }
    //}
}