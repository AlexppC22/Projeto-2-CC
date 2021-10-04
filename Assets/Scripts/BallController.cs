using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ballRb;
    public float ballSpeedX = 6;
    public float ballSpeedY = 1.2f;
    public bool canMove;

    public AudioPlayer audioPlayer;

    void Update()
    {
        if (canMove)
            ballRb.velocity = new Vector2(ballSpeedX, ballSpeedY);
        else
            ballRb.velocity = Vector2.zero;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ballSpeedX *= -1;
            //Teste aleatorio para a troca da dire��o em Y
            int chance = Random.Range(0, 4);
            if (chance == 0)
                ballSpeedY *= -1;
            //Aumenta da velocidade em X e Y de modo aleatorio
            ballSpeedX += Random.Range(0.3f, 0.9f);
            ballSpeedY += Random.Range(0.1f, 0.4f);
            audioPlayer.ballHitSFX.Play();
        }
        else if (collision.gameObject.CompareTag("Parede"))
        {
            ballSpeedY *= -1;
            audioPlayer.ballHitSFX.Play();
        }
        else if (collision.gameObject.CompareTag("Gol"))
        {
            //Sistema de pontos
            GameManager.gM.AddScore(1);
            //Reinicio da bola
            GameManager.gM.ResetBall();
            audioPlayer.golHitSFX.Play();
        }
        else if (collision.gameObject.CompareTag("GolEsquerda"))
        {
            //Sistema de pontos
            GameManager.gM.AddScore(2);
            //Reinicio da bola
            GameManager.gM.ResetBall();
            audioPlayer.golHitSFX.Play();
        }
    }

}