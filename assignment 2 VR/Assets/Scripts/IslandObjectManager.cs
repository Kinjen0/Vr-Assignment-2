using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IslandObjectManager : MonoBehaviour
{
    
    // First we will get a text object to store the notification text. 
    public Text text;
    //Two booleans for handling pickup of the paddle and consumables before the boat
    public Boolean paddlePickup = false;
    public Boolean consumablesPickup = false;
   

    //
    public void pickupPaddle()
    {
        paddlePickup = true;
        Debug.Log(paddlePickup);
    }
    public void pickupConsumables()
    {
        consumablesPickup = true;
        Debug.Log(consumablesPickup);
    }



    // Doesn't allow you to pickup boat until you have both the paddle and consumables
    public void pickupBoat(GameObject Boat)
    {

        if (paddlePickup && consumablesPickup) //When you have all necessary items you can now pickup and load next scene
        {
            text.text = "You have everything you need!";
            Boat.SetActive(false);
            
            SceneManager.LoadScene(3);
        }
        else  //Do not have both the paddle and consumables, so cannot leave yet
        {
            Debug.Log(paddlePickup);
            text.text = "I still need something for my voyage";
        }
    }

}
