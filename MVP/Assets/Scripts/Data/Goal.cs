using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int id;

    public string goalDescription;

    bool isGoalDone = false;

    public void CompleteGoal()
    {
        isGoalDone = true;
    }
   
}
