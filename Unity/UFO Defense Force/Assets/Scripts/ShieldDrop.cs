using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDrop : MonoBehaviour
{
    public GameObject[] shieldPrefab;
    private float spawnRangeX = 100f;
    private float spawnPosZ = 65f;
    private float startDelay = 4f;
    private float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnShield", startDelay, spawnInterval);
    }
    void SpawnShield()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int shieldIndex = Random.Range(0, shieldPrefab.Length);
        Instantiate(shieldPrefab[shieldIndex], spawnPos, shieldPrefab[shieldIndex].transform.rotation);
    }
}
