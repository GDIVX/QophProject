using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKill : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public bool isTargetKilled;
    
    public GoalKill(int id, string description)
    {
        this.id = id;

        this.goalDescription = description;
    }

    protected override void Evaluate()
    {
        if(isTargetKilled)
        {
            isValid = true;
            //TODO: complete quest and add xp to player.
        }
    }
}
