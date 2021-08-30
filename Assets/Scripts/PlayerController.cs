using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public int playerID;


    void Update()
    {
        switch (playerID)
        {
            case 1: // if (playerID == 0)
                if (Input.GetKey(KeyCode.S))
                {
                    Debug.Log("Apertando S");
                }
                if (Input.GetKey(KeyCode.W))
                {
                    Debug.Log("Apertando W");
                }
                break;
            case 2: //else if (player == 1)
                if (Input.GetKey(KeyCode.O))
                {
                    Debug.Log("Apertando pra O");
                }

                if (Input.GetKey(KeyCode.L))
                {
                    Debug.Log("Apertando pra l");
                }
                break;
        }
    }
}
