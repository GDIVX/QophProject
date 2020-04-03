using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public abstract class Goal:ScriptableObject
{
    public int id;

    public string goalDescription;


   protected bool isValid = false ;


   public virtual void Evaluate()
    {
        isValid = true;
    }

  public bool GetGoalValidity()
    {
        return isValid;
    }

    
   
}
