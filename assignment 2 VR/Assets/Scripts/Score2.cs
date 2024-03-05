using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    // Create an integer to store the score value
    int score;
    public Text scoreText;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    public void increaseScore(int value)
    {
        score+= value;
        scoreText.text = "Score: " + score;
    }

    public void decreaseScore(int value)
    {
        score -= value;
        scoreText.text = "Score: " + score;

    }

}
