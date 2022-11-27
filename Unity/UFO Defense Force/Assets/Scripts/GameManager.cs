using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Awake() // runs normal game time
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if (isGameOver)
        {
            EndGame(); // start EndGame method
        }
        else
            gameOverText.gameObject.SetActive(false); // keep UI text Game Over hidden
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); // reveal GameOver text
        Time.timeScale = 0; // stop time
    }
}
