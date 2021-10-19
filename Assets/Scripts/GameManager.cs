using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gM;
    public int playerOneScore;
    public int playerTwoScore;

    public BallController ball;

    public TextMeshProUGUI playerOneText;
    public TextMeshProUGUI playerTwoText;

    public int maxScore;

    public int playerID;

    public GameObject endGameUI;
    public TextMeshProUGUI winnerText;

    private void Awake()
    {
        if (GameManager.gM == null)
            gM = this;
        else
            Destroy(this);
    }

    public void AddScore(int playerID)
    {
        switch (playerID)
        {
            case 1:
                playerOneScore++; //= (playerOneScore = playerOneScore + 1) = (playerOneScore += 1)
                playerOneText.text = playerOneScore.ToString();
                if(playerOneScore >= maxScore)
                    EndGame("Jogador 1", playerOneScore);
                break;
            case 2:
                playerTwoScore++;
                playerTwoText.text = playerTwoScore.ToString();
                if(playerTwoScore >= maxScore)
                    EndGame("Jogador 2", playerTwoScore);
                break;
        }
    }

    public void EndGame(string winnerName, int winnerScore)
    {
        winnerText.text = $"{winnerName} GANHOU O JOGO COM {winnerScore} PONTOS";
        endGameUI.SetActive(true);
        ball.gameObject.SetActive(false);
    }

    public void ResetBall()
    {
        StartCoroutine(ResetBallRoutine());
    }

    private IEnumerator ResetBallRoutine()
    {
        ball.gameObject.SetActive(false);
        ball.canMove = false;
        ball.transform.position = Vector2.zero;
        yield return new WaitForSeconds(1);
        ball.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        ball.canMove = true;
    }

    public void ResetGame()
    {
        Debug.Log("Resetei o jogo");
        endGameUI.SetActive(false);
        ResetBall();
        playerOneScore = 0;
        playerTwoScore = 0;
        playerOneText.text = playerOneScore.ToString();
        playerTwoText.text = playerTwoScore.ToString();
    }
}
