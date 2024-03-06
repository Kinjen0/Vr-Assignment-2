using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRyan : MonoBehaviour
{
    //Create variables
    int score;
    public Text scoreText;

    private void Start()
    {
        score = 0; //make score 0 at start and add text to display saying score
        updateScoreText();
    }

    
    public void increaseScore (int scoreValue) 
    {
        score += scoreValue;
        updateScoreText(); //call update score
        //Debug.Log("increased score");
    }

    public void decreaseScore (int scoreValue)
    {
        score -= scoreValue;
        updateScoreText();
        //Debug.Log("Decreased Score");
    }

    public void updateScoreText () //update score on ui
    {
        scoreText.text = "Score: " + score; //update score text element
        //Debug.Log(score); //Shows points in debug log for error handling
    }
}
