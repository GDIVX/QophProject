using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quest", order = 1)]
public class Quest : ScriptableObject
{

    int id;

    public string questTitle;

    public string questDescription;

    public List<Goal> goals;

   public Goal activeGoal;

    public int xpReward;

     bool isQuestComplete = false;
    public Quest(int id,string title, string description, int xp)
    {
        this.id = id;
        this.questTitle = title;
        this.questDescription = description;
        this.xpReward = xp;
         goals = new List<Goal>();
    }

    /// <summary>
    /// Marks the quest as complete and returns the xp points to award the player.
    /// </summary>
    /// <returns></returns>
    public int CompleteQuest()
    {
        this.isQuestComplete = true;
       
        return xpReward;
    }

    public void AdvanceQuest()
    {
        activeGoal.CompleteGoal();
        if(goals.Count>activeGoal.id+1)
        {
            activeGoal = goals[activeGoal.id + 1];
        }
        else
        {
            CompleteQuest();
        }
    }



}
