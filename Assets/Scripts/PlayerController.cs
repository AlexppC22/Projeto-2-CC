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
            case 1: // if (playerID == 0)
                if (Input.GetKey(KeyCode.S))
                {
                    rb2D.velocity = new Vector2(0,-playerSpeed);

                    Debug.Log("Apertando S");
                }
                if (Input.GetKey(KeyCode.W))
                {
                    rb2D.velocity = new Vector2(0, playerSpeed);
                    Debug.Log("Apertando W");
                }
                break;
            case 2: //else if (player == 1)
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rb2D.velocity = new Vector2(0, playerSpeed);
                    Debug.Log("Apertando pra O");
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rb2D.velocity = new Vector2(0, -playerSpeed);
                    Debug.Log("Apertando pra l");
                }
                break;
        }
    }
}
