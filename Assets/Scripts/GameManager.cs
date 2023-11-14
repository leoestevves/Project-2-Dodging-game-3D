using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject stone;
    [SerializeField] Transform spawnPoint;

    [SerializeField] float maxX;

    int score = 0;

    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] float spawnFirstDelay;
    [SerializeField] float spawnUpdateDelay;
    [SerializeField] float scoreFirstDelay;
    [SerializeField] float scoreUpdateDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStone", spawnFirstDelay, spawnUpdateDelay);

        InvokeRepeating("UpdateScore", scoreFirstDelay, scoreUpdateDelay);
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

    void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
