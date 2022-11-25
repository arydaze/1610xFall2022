using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOutOfBounds : MonoBehaviour
{
    public GameObject[] shieldPrefab;
    public int shieldIndex;
    public float topBounds = 70.0f;
    public float lowerBounds = -55.0f;
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            Debug.Log("Obtained " + name);
            Instantiate(shieldPrefab[shieldIndex], new Vector3(0, 0, -48), shieldPrefab[shieldIndex].transform.rotation);
        }
    }
}
