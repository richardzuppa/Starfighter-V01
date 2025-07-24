using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tumbleEnenmy : MonoBehaviour
{
    // Start is called before the first frame update


    public float tumble;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
