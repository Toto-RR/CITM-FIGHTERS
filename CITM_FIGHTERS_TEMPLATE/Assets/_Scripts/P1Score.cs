using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P1Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreValue;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = "Player 1 \n" + scoreValue;
    }
}
