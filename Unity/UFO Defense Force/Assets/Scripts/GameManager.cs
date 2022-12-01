using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    private GameObject musicPlayer;

    void Awake() // runs normal game time
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        musicPlayer = GameObject.Find("MusicPlayer");
    }

    void Update()
    {
        if (isGameOver)
        {
            EndGame(); // start EndGame method
            StopMusic(); // start StopMusic method
        }
        else
        {
            gameOverText.gameObject.SetActive(false); // keep UI text Game Over hidden
            musicPlayer.gameObject.SetActive(true); // keep music playing
        }
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); // reveal GameOver text
        Time.timeScale = 0; // stop time
        isGameOver = true;
    }

    public void StopMusic()
    {
        musicPlayer.gameObject.SetActive(false); // disable music player
    }
}
