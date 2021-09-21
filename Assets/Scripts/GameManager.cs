using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gM;
    public int playerOneScore;
    public int playerTwoScore;

    public TextMeshProUGUI playerOneText;
    public TextMeshProUGUI playerTwoText;

    private void Awake()
    {
        if (GameManager.gM == null)
            gM = this;
        else
            Destroy(this);
    }

    public void AddScore(int playerID)
    {
        Debug.Log("Alguem fez gol");
        switch (playerID)
        {
            case 1:
                playerOneScore++; //= (playerOneScore = playerOneScore + 1) = (playerOneScore += 1)
                playerOneText.text = playerOneScore.ToString();
                break;
            case 2:
                playerTwoScore++;
                playerTwoText.text = playerTwoScore.ToString();
                break;
        }
    }

    public void ResetGame()
    {
        Debug.Log("Resetei o jogo");
    }
}
