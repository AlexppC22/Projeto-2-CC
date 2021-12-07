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
        SetPlayerNames();
    }
    public void SetPlayerNames() 
    {
        if (PhotonNetwork.IsMasterClient)
            playerName.text = PhotonNetwork.NickName;
        else
            opponentName.text = PhotonNetwork.NickName;
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
