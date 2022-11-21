using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //array to store ufo ships

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int ufoIndex = Random.Range(-100,100);
            Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 65), ufoPrefabs[ufoIndex].transform.rotation);
        }
            
    }
}
