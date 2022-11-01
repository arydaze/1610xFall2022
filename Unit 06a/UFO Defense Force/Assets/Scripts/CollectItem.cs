using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    void OnDisable()
    {
        Debug.Log("Obtained " + name);
    }
}
