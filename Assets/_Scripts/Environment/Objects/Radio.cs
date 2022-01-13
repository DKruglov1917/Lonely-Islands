using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] private AudioClip[] songs;
    [SerializeField] private AudioSource audioSource;

    private int songNumber = 0;

    public void ChooseSong()
    {
        if (songNumber > songs.Length - 1)
            songNumber = 0;

        audioSource.clip = songs[songNumber];
        songNumber += 1;
        audioSource.Play();
    }
}