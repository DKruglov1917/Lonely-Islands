using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] private AudioClip hitSound, bulk;
    private AudioSource audioSource;
    private static bool isUnderWater;

    public static void Underwater(AudioLowPassFilter lowPassFilter)
    {
        lowPassFilter.enabled = isUnderWater;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isUnderWater = false;
    }

    public void HitSound()
    {
        audioSource.clip = hitSound;
        audioSource.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            isUnderWater = true;

            audioSource.clip = bulk;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 4)
            isUnderWater = false;
    }
}
