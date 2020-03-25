using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionSetUp : MonoBehaviourPunCallbacks
{
    public static SessionSetUp instance;

    public Transform[] spawnPoints;

    private void Awake()
    {
        

    }
    private void OnEnable()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void OnSessionStarted()
    {
        Debug.Log("Session Started");
    }

    


}
