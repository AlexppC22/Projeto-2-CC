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

    public AudioSource sfxSource;

    public AudioClip pointSFX;

    private void Awake()
    {
        if (GameManager.gM == null)
            gM = this;
        else
            Destroy(this);
    }

    public void AddScore(int playerID)
    {
        sfxSource.clip = pointSFX;
        sfxSource.Play();
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
    }
}
