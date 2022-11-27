using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public GameObject[] shieldPrefab;
    public int shieldIndex;
    private void OnDisable()
    {
        Debug.Log("Obtained Shield!");
        Instantiate(shieldPrefab[shieldIndex], new Vector3(0, 0, -48), shieldPrefab[shieldIndex].transform.rotation);
    }
}
