using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioBGM : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public void PlayBgm(AudioClip audio)
    {
        audioSource.clip = audio;
        audioSource.Play();
    }


}
