
using UnityEngine;


[CreateAssetMenu(fileName = "Goal - Kill", menuName = "Goal/KIll Enemy", order = 1)]

public class GoalKill : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public GameObject target;

    public bool isTargetKilled;
    
    public GoalKill(int id, string description)
    {
        this.id = id;

        this.goalDescription = description;
    }

    public override void Evaluate()
    {
        if(isTargetKilled)
        {
            isValid = true;
            Debug.Log("Target Killed");
            //TODO: complete quest and add xp to player.
        }

    }
}
