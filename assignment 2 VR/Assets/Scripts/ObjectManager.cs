using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour
{
    // The whole point of this class is going to be to manage the current state of the various objects, and to then make the nessessary changes
    // First we will get a text object to store the notification text. 
    public Text notification;
    // Next we will have three booleans to manage the pickups
    public Boolean mapPickup = false;
    public Boolean hammerPickup = false;
    public Boolean keyPickup = false;
    public Boolean boxBroken = false;

    public GameObject key;

    // Audiosource to manage the pickup for the key
    public AudioSource sound;
    public AudioSource boxBreak;


    public void pickupMap()
    {
        mapPickup = true;
    }
    public void pickupHammer()
    {
        hammerPickup = true;
    }
    public void pickupKey(GameObject key)
    {
        if (boxBroken)
        {
            keyPickup = true;
            key.SetActive(false);
            sound.Play();
        }
    }




    // Next I want to make a function to manage the box, and i want it to only be usable if the hammerpickup is true
    public void checkHammer()
    {
        if(hammerPickup == true)
        {
            notification.text = "Break Box?";
        }
        else
        {
            notification.text = "A box? Maybe there is something here that can help me?";
        }
    }

    // Now we have to check the door
    public void checkDoor()
    {
        if(mapPickup && hammerPickup && keyPickup)
        {
            notification.text = "Open door?";
            // Place open door function here later;
        }
        else
        {
            notification.text = "I still need to pick something up.";
        }
    }

    public void breakBox(GameObject box)
    {
        if (hammerPickup)
        {
            box.SetActive(false);
            boxBroken = true;
            activateKey();
            boxBreak.Play();
            notification.text = "A Key!";
        }
    }

    public void activateKey()
    {
        key.SetActive(true);
    }

    public void checkKey()
    {
        if(boxBroken)
        {
            notification.text = "ohhh key";
        }
    }

    public void openDoor(int nextScene)
    {
        if(mapPickup && hammerPickup && keyPickup)
        {
            SceneManager.LoadScene(nextScene);
        }

    }
}
