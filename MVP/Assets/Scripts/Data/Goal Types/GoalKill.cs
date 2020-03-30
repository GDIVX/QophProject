using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKill : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;
    public GoalKill(int id, string description)
    {
        this.id = id;

        this.goalDescription = description;
    }
    
    public void CompleteGoal()
    {
        isValid = true;
       
    }
}
