using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    public float spawnRange = 12.0f;
    public int enemyAmount = 3;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(enemyAmount);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if(enemyCount < 3)
        {
            SpawnEnemy(enemyAmount);
        }
    }
    
    void SpawnEnemy(int enemiesToSpawn)
    {
        for (int i = 3; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    //Spawn Position
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosz = Random.Range(-spawnRange, spawnRange);
        
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosz);
        return randomPos;
    } 
}

