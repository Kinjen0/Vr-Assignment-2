using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IslandObjectManager : MonoBehaviour
{
    // The whole point of this class is going to be to manage the current state of the various objects, and to then make the nessessary changes
    // First we will get a text object to store the notification text. 
    public Text text;
    // Next we will have three booleans to manage the pickups
    public Boolean paddlePickup = false;
    public Boolean consumablesPickup = false;
   


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



    // Now we have to check the door
    public void pickupBoat(GameObject Boat)
    {
        if (Boat == null)
        {
            Debug.LogError("Boat GameObject is null!");
            return;
        }

        if (paddlePickup && consumablesPickup)
        {
            text.text = "You have everything you need!";
            Boat.SetActive(false);
            SceneManager.LoadScene(3);
        }
        else
        {
            Debug.Log(paddlePickup);
            text.text = "I still need something for my voyage";
        }
    }

}
