using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] private AudioClip[] songs;
    private AudioLowPassFilter audioLowPassFilter;
    private AudioSource audioSource;
    private int songNumber = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioLowPassFilter = GetComponent<AudioLowPassFilter>();
    }

    public void ChooseSong()
    {
        if (songNumber > songs.Length)
            songNumber = 0;

        audioSource.clip = songs[songNumber];
        songNumber += 1;
        audioSource.Play();
    }

    private void Update()
    {
        PlayerSound.Underwater(audioLowPassFilter);
    }
}