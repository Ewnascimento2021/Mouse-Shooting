using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Rigidbody ballPrefab;
    [SerializeField]
    private int eixoX;
    [SerializeField]
    private int eixoY;

    private Rigidbody ballNow;
    private int minEixoX;
    private int eixoZ = -4;
    private Vector3 ballPosition;
    
    

    void Start()
    {
        minEixoX = ((eixoX - 1) / 2);
        CreateBall();
    }


    void Update()
    {
        if (!ballNow.GetComponent<SphereController>().IsBallAlive)
        {
            CreateBall();
        }
    }

    // Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    private void CreateBall()
    {
        ballPosition = new Vector3(Random.Range(minEixoX, -minEixoX), (Random.Range(0, eixoY) + 0.3f), eixoZ);
        ballNow = Instantiate(ballPrefab, ballPosition, ballPrefab.transform.rotation);
    }
}
