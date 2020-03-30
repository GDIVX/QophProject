using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Goal", menuName = "Goal", order = 2)]

public abstract class Goal  
{
    public int id;

    public string goalDescription;

   protected bool isValid = true ;


    

    //public void CompleteGoal()
    //{
    //    isGoalDone = true;
    //}
   
}
