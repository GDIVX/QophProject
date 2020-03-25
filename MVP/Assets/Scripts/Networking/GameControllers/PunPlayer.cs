using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PunPlayer : MonoBehaviour
{
    private PhotonView photonView;

    public GameObject avatar;
    public Photon.Realtime.Player client;


    private void Awake()
    {
        photonView = GetComponent<PhotonView>();
    }

    private void Start()
    {
        FindAndJoinATeam();
    }

    void FindAndJoinATeam()
    {
        //Team[] teams = GameTracker.instance.teams;
        //foreach(Team team in teams)
        //{
        //    if (team.CanJoin())
        //    {
        //        team.Join(this);
        //        return;
        //    }
        //}
        //GameTracker.instance.MakeSpaceInTeams();
        //FindAndJoinATeam();
    }
}
