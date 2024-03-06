using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Code from https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
public class Timer : MonoBehaviour
{
    public float time; //Initially set time for countdown
    public Text text;
    // A shape that will let us exit the level if we want. it will appear after 3 minutes
    public GameObject exitShape;

    private Boolean hasTimeLeft = true; //Boolean for if timer is still running or not

    void Update()
    {
        float minutes = Mathf.FloorToInt(time / 60);  //Calculate minutes and seconds from remaining time
        float seconds = Mathf.FloorToInt(time % 60);

        //Checks if there is time remaining
        if (time > 0)
        {
            time -= Time.deltaTime; // Decrease the time based on real time passed since last frame
            text.text = minutes + " : " + seconds;  // Update the UI text to display the remaining time
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
            exitShape.SetActive(true); //Activates the object with gaze over event attached to end game
        }
    }

    public void endGame()
    {
        Application.Quit();
    }
}