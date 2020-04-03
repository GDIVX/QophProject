using Photon.Realtime;
using UnityEngine;


[CreateAssetMenu(fileName = "Goal - Capture Position", menuName = "Goal/Capture Position", order = 5)]

public class GoalCapture : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public Collider locationToCapture;

    Player player;

    public GoalCapture(int id, string description)
    {
        this.id = id;

        this.goalDescription = description;


    }

    public override void Evaluate()
    {
        if (Camera.main.transform.position == locationToCapture.ClosestPoint(locationToCapture.transform.position))
        {
            isValid = true;
            Debug.Log("Location Captured!");
        }
        //TODO: complete quest and add xp to player.
    }

}
