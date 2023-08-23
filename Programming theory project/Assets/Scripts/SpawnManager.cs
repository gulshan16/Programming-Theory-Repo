using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float spawnRange = 17;
    public int enemiesToSpawn = 5;
    private float startDelay = 2;
    private float repeatRate = 5;

    void Start()
    {
        //spawnEnemy();
        InvokeRepeating("SpawnEnemy",startDelay,repeatRate);
    }

    
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        for(int i = 0; i< enemiesToSpawn; i++)
        {
            int randomEnemy = Random.Range(0,enemyPrefab.Length);
            Instantiate(enemyPrefab[randomEnemy],GenerateSpawnPosition(),enemyPrefab[randomEnemy].transform.rotation);
        }
    } 
    private Vector3 GenerateSpawnPosition(){
        float spawnPosX = Random.Range(-spawnRange,spawnRange);
        float spawnPosZ = Random.Range(100,145);
        Vector3 randomPos = new Vector3(spawnPosX,0,spawnPosZ);
        return randomPos;
    }
}
