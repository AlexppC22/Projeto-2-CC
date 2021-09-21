using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ballRb;
    public float ballSpeedX = 6;
    public float ballSpeedY = 1.2f;

    void Update()
    {
        ballRb.velocity = new Vector2(ballSpeedX, ballSpeedY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ballSpeedX *= -1;
            //Teste aleatorio para a troca da direção em Y
            int chance = Random.Range(0, 4);
            if (chance == 0)
                ballSpeedY *= -1;
            //Aumenta da velocidade em X e Y de modo aleatorio
            ballSpeedX += Random.Range(0.3f, 0.9f);
            ballSpeedY += Random.Range(0.1f, 0.4f);
            
        }
        else if (collision.gameObject.CompareTag("Parede"))
        {
            ballSpeedY *= -1;
        }
        else if (collision.gameObject.CompareTag("Gol"))
        {
            this.gameObject.SetActive(false);
            this.transform.position = Vector2.zero;
            GameManager.gM.AddScore(1);
            this.gameObject.SetActive(true);
        }
    }
}
