using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI opponentName;
    private void Start()
    {
      
    }
    public void OnPlayerConnected(Player player)
    {
        Debug.Log("jogador conectou " + player.NickName);
        
    }

    public override void OnPlayerEnteredRoom(Player player)
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2 && PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel(3);
        }

    }
   
    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        PhotonNetwork.Disconnect();
    }

}
