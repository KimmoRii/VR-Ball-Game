using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    void Start()
    {
        UpdateScoreUI();
    }

    public void IncreaseScore()
    {
        score += 1;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
