using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject stone;
    public Transform spawnPoint;

    public float maxX;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStone", 0.5f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStone()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate(stone, spawnPos, Quaternion.identity);
    }
}
