using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PUN_Enable_Character_Controller : MonoBehaviour
{
    
    private PhotonView PV;
    private GameObject PlayerCharacter;
    

    private void Awake()
    {
        PlayerCharacter = transform.GetChild(0).gameObject;
        
    }


    void Start()
    {
        PV = GetComponent<PhotonView>();
        if (PV.IsMine == false && PhotonNetwork.IsConnected == true || PV.IsMine == false && PhotonNetwork.IsConnected == false)
        {
            return;
            
        }

        else { PlayerCharacter.SetActive(true); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
