using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;


public class LobbyManager : MonoBehaviourPunCallbacks
{
    public string gameVersion;
    public TextMeshProUGUI feedbackText;
    private void Awake() 
    {
        PhotonNetwork.AutomaticallySyncScene = true;    
    }

    private void Start() 
    {
        feedbackText.text = "DESCONECTADO";
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("<color=red>Conectou no servidor</color>");
        feedbackText.text = "CONECTADO";
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
        PhotonNetwork.CreateRoom("sala");
        Debug.Log("<color=blue>sem sala, criando nova sala</color>");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("<color=cyan>Juntou-se a sala</color>");
        PhotonNetwork.LoadLevel(2);    
    
    }


    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
        Debug.Log("<color=red>Desconectou do servidor:</color> " + cause);
    }

    public void Connect()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = gameVersion;
            feedbackText.text = "CONECTANDO...";

        }
    }




}



