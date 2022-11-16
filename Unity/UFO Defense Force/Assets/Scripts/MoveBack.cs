using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        // Move GameObject backward
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
