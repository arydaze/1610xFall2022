using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store ufo ships
    private float spawnRangeX = 90f;
    private float spawnPosZ = 65f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO",startDelay,spawnInterval);
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); //picks random ufo from array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //spawns indexed ufo from array at random location on X axis
    }
}
