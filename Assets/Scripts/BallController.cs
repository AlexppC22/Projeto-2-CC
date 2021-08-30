using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D ballRb;
    public float ballSpeedX = 6;
    public float ballSpeedY = 1.2f;
    void Start()
    {
        
    }
    void Update()
    {
        ballRb.velocity = new Vector2(ballSpeedX, ballSpeedY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballSpeedX *= -1;
        ballSpeedY *= -1;
    }
}
