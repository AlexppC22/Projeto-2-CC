using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public int playerID;
    public int playerSpeed = 5;

    void Update()
    {   
        switch (playerID)
        {
            case 1: // if (playerID == 1)
                if (Input.GetKeyDown(KeyCode.S))
                {
                    rb2D.velocity = new Vector2(0,-playerSpeed);
                }
                if (Input.GetKeyDown(KeyCode.W))
                {
                    rb2D.velocity = new Vector2(0, playerSpeed);
                }
                break;
            case 2: //else if (player == 2)
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb2D.velocity = new Vector2(0, playerSpeed);
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    rb2D.velocity = new Vector2(0, -playerSpeed);
                }
                break;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GameManager.gM.ResetGame();
        }
    }
}
