using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SessionMannager : MonoBehaviourPunCallbacks
{
    public Transform PlayerAvatarPrefab;
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player other)
    {
        Debug.LogFormat("OnPlayerEnteredRoom() {0}", other.NickName);
        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient);
            SessionLuncher.instance.LoadScene();
        }
    }

    private void Start()
    {
        SpawnPlayer();
    }

    public override void OnPlayerLeftRoom(Player other)
    {
        Debug.LogFormat("OnPlayerLeftRoom() {0}", other.NickName);


        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerLeftRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient);


            SessionLuncher.instance.LoadScene();
        }
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void SpawnPlayer()
    {
        if (PlayerAvatarPrefab == null)
        {
            Debug.LogError("Missing a prefab for the player");
            return;
        }

        Debug.Log("Founded a prefab to the player. Spawning");
        PhotonNetwork.Instantiate(this.PlayerAvatarPrefab.name,
           SessionSetUp.instance.spawnPoints[Random.Range(0, SessionSetUp.instance.spawnPoints.Length)].position,
            Quaternion.identity);
    }

}
