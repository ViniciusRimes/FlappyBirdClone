using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject option;

   

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
        SceneManager.LoadScene("JogoPrincipal");
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

}
