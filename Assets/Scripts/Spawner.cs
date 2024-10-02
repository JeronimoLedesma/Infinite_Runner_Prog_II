using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaculo;
    public float delay;
    public float repeat;
    public Vector2 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeat);
    }

    void SpawnObstacle()
    {
        int randomIndex = Random.Range(0, obstaculo.Length);
        GameObject obstacle = obstaculo[randomIndex];
        Instantiate(obstacle, spawnPos, obstacle.transform.rotation);  
    }
}
