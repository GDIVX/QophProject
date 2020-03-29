using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int id;

    public string goalDescription;

    bool isGoalDone = false;


    public Goal(int id, string description)
    {
        this.id = id;
        goalDescription = description;
    }

    public void CompleteGoal()
    {
        isGoalDone = true;
    }
   
}
