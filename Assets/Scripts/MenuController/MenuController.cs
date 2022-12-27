using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("Menu")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject option;
    [SerializeField] private GameObject explication;

    public bool Music;


    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void NewGame()
    {
        explication.SetActive(true);
    }

    void Options()
    {
        option.SetActive(true);
        mainMenu.SetActive(false);
    }

    void BackMenu()
    {
        option.SetActive(false);
        mainMenu.SetActive(true);
    }

    void ExitGame()
    {
        Application.Quit();
    }

    void Explication()
    {
        explication.SetActive(false);
        SceneManager.LoadScene("JogoPrincipal");
    }
    
}
