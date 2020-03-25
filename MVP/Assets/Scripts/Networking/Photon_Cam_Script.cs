using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Photon_Cam_Script : MonoBehaviour
{
    PhotonView MyPhotonView;
    [SerializeField] Camera MyCam;


    private void Start()
    {

        MyPhotonView = GetComponent<PhotonView>();

        if (!MyPhotonView.IsMine)
        {
            MyCam.enabled = false;
        }
    }
}
