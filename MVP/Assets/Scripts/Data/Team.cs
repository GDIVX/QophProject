using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team 
{
    /// <summary>
    /// A class that represent a team in a multiplayer game.
    /// Holds a collection of GameObjects taged as player. 
    /// </summary>
    public List<PunPlayer> members;
    public int id;

    public Team(int id){
        members = new List<PunPlayer>();
        this.id = id;
    }
    public List<PunPlayer> Members { get => members;}

    public void Join(PunPlayer player){
        if (!CanJoin())
        {
            Debug.LogError("Trying to joing a full team without making space first");
            return;
        }
        members.Add(player);
        
    }
    
    public bool CanJoin()
    {
        return GameTracker.instance.CanJoinTeam(this);
    }

}
