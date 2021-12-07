using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class InputPlayerName : MonoBehaviour
{
    public InputField playerInput;
    public string playerName;
    
    void Start()
    {
        PhotonNetwork.NickName = playerName;
        
    }

    public void SetPlayerName(string nickName)

    {
        if (string.IsNullOrEmpty(nickName))
            return;
        PhotonNetwork.NickName = nickName;



    }
}
