using Photon.Realtime;
using UnityEngine;

[CreateAssetMenu(fileName = "Goal - Escort", menuName = "Goal/Escort NPC", order = 4)]

public class GoalEscort : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public GameObject npcToEscort;

    public GameObject escortDestination;


    GoalEscort(int id, string description, GameObject npc, GameObject destination)
    {
        this.id = id;
        this.goalDescription = description;
        npcToEscort = npc;
        escortDestination = destination;
    }

    public override void Evaluate()
    {
        if (npcToEscort.transform.position == escortDestination.transform.position)
        {
            isValid = true;
            Debug.Log("Escort complete");

        }
        if (npcToEscort== null || npcToEscort.activeSelf == false)
        {
            isValid = false;
            Debug.Log("Escort Failed");


        }
    }
}
