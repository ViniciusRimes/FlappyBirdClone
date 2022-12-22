using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Player player;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private GameObject Score;
    [SerializeField] private GameObject options;
    
    [Header("Medals")]
    [SerializeField] private GameObject medalZero;
    [SerializeField] private GameObject medalBronze;
    [SerializeField] private GameObject medalGold;
    [SerializeField] private GameObject medalSilver;



    [Header("Score")]
    public int score;
    public int bestScore;
    public int totalBestScore;
    [Header("ScoreText")]
    public Text scoreText;
    public Text scoreTextMedal;
    public Text TextBestScore;



    void Start()
    {
        Time.timeScale = 1;
        player = FindObjectOfType<Player>();
    }

    void Update()
    {   
        GameOver();
        totalBestScore = PlayerPrefs.GetInt("bestScore");
        Medals();
    }

    void GameOver()
    {
        totalBestScore = PlayerPrefs.GetInt("bestScore");
        if(player.gameOver)
        {
            GameOverPanel.SetActive(true);
            Score.SetActive(false);
            Time.timeScale = 0;
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene("JogoPrincipal");
    }

    
    void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void PauseGame()
    {
        options.SetActive(true);
        Time.timeScale = 0;
    }

    void BackGame()
    {
        options.SetActive(false);
        Time.timeScale = 1;
    }

    void Medals()
    {
        if(score == 0 && score < 50)
        {
            medalZero.SetActive(true);
        }
        if(score >= 50 && score < 100)
        {
            medalZero.SetActive(false);
            medalBronze.SetActive(true);
        }
        if(score >= 100 && score < 150)
        {
            medalBronze.SetActive(false);
            medalSilver.SetActive(true);
            
        }
        if(score > 150)
        {
            medalSilver.SetActive(false);
            medalGold.SetActive(true);
        }
    }

}