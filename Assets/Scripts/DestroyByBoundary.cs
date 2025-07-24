using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    //Ao sair dos limites pré definidos no Game Object
    //um gatilho é disparado e ativa a função
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
