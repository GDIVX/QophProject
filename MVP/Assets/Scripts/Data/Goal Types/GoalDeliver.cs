using UnityEngine;

[CreateAssetMenu(fileName = "Goal - Deliver Item", menuName = "Goal/Deliver Item", order = 2)]

public class GoalDeliverItem : Goal
{
    int Id => id = 0;

    public string description => goalDescription;

    public bool isCompleted => isValid;

    public GameObject itemToDeliver;

    public GameObject deliveryDestination;


    GoalDeliverItem (int id , string description, GameObject item, GameObject destination)
    {
        this.id = id;
        this.goalDescription = description;
        itemToDeliver = item;
        deliveryDestination = destination;
    }

    public override void Evaluate()
    {
        if(itemToDeliver.transform.position == deliveryDestination.transform.position)
        {
            isValid = true;
            Debug.Log("Item delivered");

        }
        else
        {
            if(itemToDeliver==null || itemToDeliver.activeSelf == false)
            {
                isValid = false;
                Debug.Log("Quest Failed");
            }

        }

    }
}
