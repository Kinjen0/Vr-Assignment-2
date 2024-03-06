using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRyan : MonoBehaviour
{
    int score;
    public Text scoreText;

    private void Start()
    {
        score = 0;
        updateScoreText();
    }

    
    public void increaseScore (int scoreValue)
    {
        score += scoreValue;
        updateScoreText();
        Debug.Log("increased score");
    }

    public void decreaseScore (int scoreValue)
    {
        score -= scoreValue;
        updateScoreText();
        Debug.Log("Decreased Score");
    }

    public void updateScoreText ()
    {
        scoreText.text = "Score: " + score;
        Debug.Log(score);
    }
}
