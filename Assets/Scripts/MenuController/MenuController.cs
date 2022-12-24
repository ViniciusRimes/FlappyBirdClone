using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject option;
    [SerializeField] private GameObject explication;

   

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        explication.SetActive(true);
    }

    public void Options()
    {
        option.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void BackMenu()
    {
        option.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Explication()
    {
        explication.SetActive(false);
        SceneManager.LoadScene("JogoPrincipal");
    }
}
