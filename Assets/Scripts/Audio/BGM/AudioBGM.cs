using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBGM : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    void PlayBgm(AudioClip audio)
    {
    
        audioSource.clip = audio;
        audioSource.Play();

        
    }


}
