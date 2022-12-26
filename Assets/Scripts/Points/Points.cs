using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [Header("Components")]
    private GameController controller;
    [SerializeField] private AudioClip clipPoint;
    [SerializeField] private AudioSource audioSource;
    
    void Start()
    {
        controller = FindObjectOfType<GameController>();
        
    }
    void Update()
    {
        controller.TextBestScore.text = controller.totalBestScore.ToString();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSFX(clipPoint);
        controller.score += 10;
        controller.scoreText.text = controller.score.ToString();
        controller.scoreTextMedal.text = controller.score.ToString();

        if(controller.score >= controller.totalBestScore)
        {
            controller.bestScore = controller.score;
            PlayerPrefs.SetInt("bestScore", controller.bestScore);
        }
    }    
   
    void audioSFX(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    
}
