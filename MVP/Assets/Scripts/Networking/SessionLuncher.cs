using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionLuncher : MonoBehaviour
{
    public static SessionLuncher instance;

    public int minimunPlayerCount;
    public bool sceneLoaded = false;
    public event sessionStartedDel sessionStarted;

    public delegate void sessionStartedDel();
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    string error;
    public void TryStartSession() 
    {
        if (CanJoin())
        {
            LoadScene();
        }
        else
        {
            sceneLoaded = false;
            Debug.LogError(error);
        }
    }


    private bool CanJoin()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            error = "PhotonNetwork : Trying to Load a level but we are not the master Client";
            return false;
        }
        if(minimunPlayerCount > PhotonNetwork.CurrentRoom.PlayerCount)
        {
            error = "PhotonNetwork : trying to lad a level while the minimun amount of players have not been reached";
            return false;
        }

        return true;
    }

    public void LoadScene()
    {
        //TODO have a proper loading system
        PhotonNetwork.LoadLevel(1);

        sceneLoaded = true;
    }
}
