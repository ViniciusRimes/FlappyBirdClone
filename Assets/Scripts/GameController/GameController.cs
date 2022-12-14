using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   
    
    private Player player;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private GameObject score;
    [SerializeField] private GameObject options;

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
        score.SetActive(false);
        Time.timeScale = 0;
    }
}

public void RestartGame()
{
    SceneManager.LoadScene("JogoPrincipal");
}

public void BackMenu()
{
    SceneManager.LoadScene("MainMenu");
}

public void PauseGame()
{
    options.SetActive(true);
    Time.timeScale = 0;
}

public void BackGame()
{
    options.SetActive(false);
    Time.timeScale = 1;
}


}
