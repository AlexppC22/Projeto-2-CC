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
        SetPlayerNames(PhotonNetwork.LocalPlayer);
    }
    public void OnPlayerConnected(Player player)
    {
        Debug.Log("jogador conectou " + player.NickName);
        SetPlayerNames(player);
    }
    public void SetPlayerNames(Player player) 
    {
        if (player.IsMasterClient)
            playerName.text = player.NickName;
        else
            opponentName.text = player.NickName;
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
