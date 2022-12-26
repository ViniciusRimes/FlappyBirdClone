using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("GameOver")]
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private GameObject Score;
    [SerializeField] private GameObject options;
    
    [Header("Medals")]
    [SerializeField] private GameObject medalZero;
    [SerializeField] private GameObject medalBronze;
    [SerializeField] private GameObject medalGold;
    [SerializeField] private GameObject medalSilver;
    
    [Header("GetReady")]
    [SerializeField] private GameObject number1;
    [SerializeField] private GameObject number2;
    [SerializeField] private GameObject number3;
    [SerializeField] private GameObject getReady;
    private bool _gameInitial;
    [HideInInspector]public bool gameInitial{get{return _gameInitial;} set{_gameInitial = value;}}
    
    [Header("Components")]
    [SerializeField] private Player player;
    [SerializeField] private AudioSource audioSource;
    public float currentTime = 0;


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
        _gameInitial = false;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
    }

    void Update()
    {   

        currentTime += Time.deltaTime;
        GameOver();
        totalBestScore = PlayerPrefs.GetInt("bestScore");
        Medals();
        GetReady();
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

    void GetReady()
    {
        if(currentTime > 0f && currentTime <= 1f)
        {
            number3.SetActive(true);
        }
        if(currentTime > 1f && currentTime <= 2f)
        {
            number3.SetActive(false);
            number2.SetActive(true);
        }
        if(currentTime > 2f && currentTime <= 3f)
        {
            number2.SetActive(false);
            number1.SetActive(true);
        }
        if(currentTime > 3f && currentTime <= 4f)
        {
            number1.SetActive(false);
            getReady.SetActive(true);
        }
        if(currentTime > 4f)
        {
            getReady.SetActive(false);
             _gameInitial = true;
            player.GetComponent<Rigidbody2D>().gravityScale = 0.7f;
        }
    }


}