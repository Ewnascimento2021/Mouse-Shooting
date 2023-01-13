using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private Rigidbody rb;

    private bool isBallAlive = true;

    public bool IsBallAlive { get => isBallAlive; set => isBallAlive = value; }


    private void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        isBallAlive = false;
        rb.position = new Vector3(Random.Range(-1f,1f),5,Random.Range(-1f,1f));
        rb.useGravity = true;
    }

}
