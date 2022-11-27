using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro for UI library

public class ScoreManager : MonoBehaviour
{
    public int score; // keep score value
    public TextMeshProUGUI scoreText; // visual text element to modify

    public void IncreaseScore(int amount) // when called increases score by amount set in score variable
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // when called increases score by amount set in score variable
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // updates score in the HUD UI text
    {
        scoreText.text = "Score: "+ score;
    }
}
