using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quest", order = 1)]
public class Quest : ScriptableObject
{

    int id;

    public string questTitle;

    public string questDescription;

    public Goal goal;

    public int xpReward;

    bool isQuestComplete = false;


    public Quest(int id, string title, string description, int xp)
    {
        this.id = id;
        this.questTitle = title;
        this.questDescription = description;
        this.xpReward = xp;

    }

    //public void AdvanceQuest()
    //{
    //    activeGoal.CompleteGoal();
    //    if (goals.Count > activeGoal.id + 1)
    //    {
    //        activeGoal = goals[activeGoal.id + 1];
    //    }
    //    else
    //    {
    //        CompleteQuest();
    //    }
    //}

    public void QuestCallback()
    {
        if (goal.GetGoalValidity())
        {
            GameTracker.instance.OnQuestComplete_CallBack(this);
        }
        else
        {
            GameTracker.instance.OnQuestIncompletable_callBack(this);
        }
    }

}
