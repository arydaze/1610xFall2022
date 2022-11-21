using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject[] shieldPrefab;

    public int shieldIndex;
    void OnDisable()
    {
        Debug.Log("Obtained " + name);
        Instantiate(shieldPrefab[shieldIndex], new Vector3(0, 0, -36), shieldPrefab[shieldIndex].transform.rotation);
    }
}
