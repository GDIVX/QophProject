
using UnityEngine;


[CreateAssetMenu(fileName = "Goal - Capture Position", menuName = "Goal/Capture Position", order = 5)]

public class GoalCapture : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public GameObject locationToCapture; 

    public GoalCapture(int id, string description)
    {
        this.id = id;

        this.goalDescription = description;


    }

    public void LocationCaptured()
    {
        isValid = true;
        Debug.Log("Location Captured!");
        //TODO: complete quest and add xp to player.
    }

}
