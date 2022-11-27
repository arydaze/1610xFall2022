using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //store reference to score manager
    public int scoreToGive;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // find ScoreManager gameobject and reference ScoreManager script component
    }
    void OnTriggerEnter(Collider other) // once trigger is entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // increase score
        Destroy(other.gameObject); // Destroy object it hits
        Destroy(gameObject); // Destroy game object
    }
}
