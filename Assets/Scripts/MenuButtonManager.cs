using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditScreen;

    public void quitGame()
    {
        //Application.Quit(); //only works outside of editor
        UnityEditor.EditorApplication.isPlaying = false; //only works in editor
    }

    public void openCredits()
    {
        creditScreen.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void openMain()
    {
        mainMenu.SetActive(true);
        creditScreen.SetActive(false);
    }
}
