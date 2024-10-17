using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject selectCharacter;
    public GameObject mainMenu;


    public void OnSelectCharacter()
    {
        selectCharacter.SetActive(true);
        mainMenu.SetActive(false);
    }


    public void OnPlayButoon()
    {
        SceneManager.LoadScene("ZombieLand");
    }

    public void OnQuitButton()
    {
        Debug.Log("quitting Game....");
        Application.Quit();
    }
}
