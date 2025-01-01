using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(string itemTag)
    {
        // Add points based on the item type
        if (itemTag == "Apple")
            score += 10;
        else if (itemTag == "Coin")
            score += 5;

        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
