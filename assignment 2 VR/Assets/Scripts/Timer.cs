using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Code from https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
public class Timer : MonoBehaviour
{
    public float time;
    public Text text;
    // A shape that will let us exit the level if we want. it will appear after 3 minutes
    public GameObject exitShape;

    private Boolean hasTimeLeft = true;

    void Update()
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);


        if (time > 0)
        {
            time -= Time.deltaTime;
            text.text = minutes + " : " + seconds;
        }
        else
        {
            // With the time running out it is time to display a message 
            timeOut();
        }
    }

    private void timeOut()
    {
        if(hasTimeLeft)
        {
            hasTimeLeft = false;
            text.text = "Hey, its been a little while, \n" +
                "would you like to take a breaK?" +
                "\n Click on the red sphere above you to quit.";
            exitShape.SetActive(true);
        }
    }

    public void endGame()
    {
        Application.Quit();
    }
}