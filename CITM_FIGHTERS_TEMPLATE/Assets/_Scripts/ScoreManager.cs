using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int playerScore = 0;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void IncreaseScore()
    {
        playerScore++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Player 1: " + playerScore;
    }
}
