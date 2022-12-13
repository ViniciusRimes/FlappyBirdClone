using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Player player;
    [SerializeField] private GameObject GameOverPanel;

    public int Score;
    public Text scoreText;


void Start()
{
    Time.timeScale = 1;
    player = FindObjectOfType<Player>();
}

void Update()
{
    GameOver();
}

public void GameOver()
{
    if(player.gameOver)
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}

public void RestartGame()
{
    SceneManager.LoadScene("JogoPrincipal");
}
    
}
