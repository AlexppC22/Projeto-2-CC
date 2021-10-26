using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using DG.Tweening;
using Photon.Pun;
using Photon;

public class MainMenuManager : MonoBehaviour
{
    public void ButtonStartGame()
    {
        SceneManager.LoadScene("GameScene");
        
    }

    public void ButtonSettings()
    {
        Debug.Log("<color=cyan>Settings</color>");
    }

    public void ButtonQuitGame()
    {
        Debug.Log("<color=red>Quit Game</color>");
        Application.Quit();
    }
}
