using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This script is triggering audio when used with GazeOverEvent.cs script.
 */

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource stopSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();// get component <> is used to direct to the audio source component instead of ()
    }

    public void PlaySong()
    {
        audioSource.Play();                //play an audio
    }
    // create a functino to play the stop sound when its time
    public void PlayStopSong()
    {
        stopSound.Play();
    }
}
