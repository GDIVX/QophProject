using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationCollider : MonoBehaviour
{
    public GoalReachDestination relatedGoal;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera")
        {
            relatedGoal.DestinationReached();
        }
    }
}
