using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    int score;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = GetComponent<Text>();
        text.text = "Score: " + score.ToString();
    }



    public void IncreaseScore()
    {
        score += 1;
        text.text = "Score: " + score.ToString();
    }
    
    public void DecreaseScore()
    {
        score -= 1;
        text.text = "Score: " + score.ToString();
    }
}
