using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public static Pipe instance;
    public int score = 0;

    public GameObject pipePrefab;
    public float spawnInterval = 2f;
    public float minY = -2f;
    public float maxY = 2f;
    
    float timer = 0f;
    public bool isGameOver = false;

    public void GameOver()
    {
        isGameOver = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            float randomY = Random.Range(minY, maxY);
            Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);

            Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
