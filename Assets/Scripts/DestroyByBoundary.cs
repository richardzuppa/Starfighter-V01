using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    //Ao sair dos limites pr� definidos no Game Object
    //um gatilho � disparado e ativa a fun��o
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
