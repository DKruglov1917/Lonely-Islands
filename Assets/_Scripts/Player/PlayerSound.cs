using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] private AudioLowPassFilter audioLowPassFilter;
    [SerializeField] private AudioClip _hit, _bulk, _underwater;
    [SerializeField] private AudioSource audioSource;
    private bool isUnderWater;

    public void HitSound()
    {
        audioSource.PlayOneShot(_hit);
    }

    private void Underwater()
    {
        audioLowPassFilter.enabled = isUnderWater;
    }

    private void Start()
    {
        isUnderWater = false;
    }

    private void Update()
    {
        Underwater();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            isUnderWater = true;

            audioSource.PlayOneShot(_bulk);
            audioSource.clip = _underwater;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 4)
            isUnderWater = false;

        audioSource.Stop();
    }
}
