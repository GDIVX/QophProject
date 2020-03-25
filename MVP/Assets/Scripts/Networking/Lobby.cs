using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Lobby : MonoBehaviourPunCallbacks
{
    public static Lobby instance; 
    public GameObject quickStartButton; 
    public GameObject cancelButton;
    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }

    public void ConnectToRandomSession()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public void OnQuickStartClicked(){
        Debug.Log("Searching for room...");
        quickStartButton.SetActive(false);
        cancelButton.SetActive(true);
        ConnectToRandomSession();
    }

    public void OnCancelButtonClicked(){
        Debug.Log("Cancled");
        cancelButton.SetActive(false);
        quickStartButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }
    public override void OnConnectedToMaster(){
        Debug.Log("Connected to master server.");
        quickStartButton.SetActive(true);
    }

    public override void OnJoinRandomFailed(short returnCode, string message){
        Debug.Log("Couldn't join a room. Trying to create a new one now.");
        CreateRoom();
    }

    void CreateRoom(){
        Debug.Log("Creating a new room.");
        int randomRoomName = Random.Range(1,1000);
        RoomOptions roomOptions = new RoomOptions(){IsVisible = true , IsOpen = true , MaxPlayers = 12};
        PhotonNetwork.CreateRoom("Room"+randomRoomName,roomOptions);
    }

    public override void OnCreateRoomFailed(short returnCode, string message){
        Debug.Log("Failed to create room. trying again.");
        CreateRoom();
    }

    public override void OnJoinedRoom(){
        Debug.Log("Joined a room");
        while (!SessionLuncher.instance.sceneLoaded)
        {
            SessionLuncher.instance.TryStartSession();
        }
    }
}
