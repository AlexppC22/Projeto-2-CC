using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void ButtonStartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Settings()
    {
        Debug.Log("<color=cyan>Abrir menu de configurações</color>");
    }

    public void QuitGame()
    {
        Debug.Log("<color=red>Fechar jogo</color>");
        Application.Quit();
    }
}
