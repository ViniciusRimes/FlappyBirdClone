using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;
    
    
    
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
        
        controller.score += 10;
        controller.scoreText.text = controller.score.ToString();
        controller.scoreTextMedal.text = controller.score.ToString();

        if(controller.score >= controller.totalBestScore)
        {
            controller.bestScore = controller.score;
            PlayerPrefs.SetInt("bestScore", controller.bestScore);
        }
    }
    
    
}
