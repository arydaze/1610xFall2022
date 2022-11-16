using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 50.0f;
    public float lowerBounds = -45.0f;

    void Awake()
    {
        // Time.timeScale = 1;
    }

    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            // Time.timeScale = 0;
        }
    }
}
