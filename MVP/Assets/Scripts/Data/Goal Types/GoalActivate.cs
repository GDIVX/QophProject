
using UnityEngine;
[CreateAssetMenu(fileName = "Goal - Activate an Item", menuName = "Goal/Activate Item", order = 3)]

public class GoalActivate : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public GameObject itemToActivate;



    GoalActivate(int id, string description, GameObject item)
    {
        this.id = id;
        this.goalDescription = description;
        itemToActivate = item;
    }

    public override void Evaluate()
    {
        //TODO: some system that checks if the player activated the item.
        //if )
        //{
            isValid = true;
            Debug.Log("Item delivered");
        //}
    }
}
