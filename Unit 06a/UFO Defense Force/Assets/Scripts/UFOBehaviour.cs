using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOBehaviour : MonoBehaviour
{
    public float speed;
    public float playerDeath;
    // Update is called once per frame
    void Update()
    {
        // Move GameObject backward
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
    private void OnDisable()
    {
        if (transform.position.z < playerDeath)
        {
            Debug.Log("Game Over!");
            speed = -10;
        }
    }
}
