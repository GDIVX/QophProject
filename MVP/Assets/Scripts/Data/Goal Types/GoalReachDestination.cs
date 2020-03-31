
using UnityEngine;

[CreateAssetMenu(fileName = "Goal - Reach Destination", menuName = "Goal/Reach Destination", order = 2)]

public class GoalReachDestination : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;



    public GoalReachDestination(int id, string description)
    {
        this.id = id;

        this.goalDescription = description;

    }

    public void DestinationReached()
    {
        isValid = true;
        Debug.Log("Destination Reached!");
        //TODO: complete quest and add xp to player.
    }
    //protected override void Evaluate()
    //{
    //    GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

    //    if (destinationCollider.)
    //    {
    //        isValid = true;
    //        Debug.Log("Destination Reached!");
    //        //TODO: complete quest and add xp to player.
    //    }
    //}
}
