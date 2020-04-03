using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayQuest:MonoBehaviour
{
    
    public Quest quest;

    public Text titleText;

    public Text descriptionText;

    public Text xpText;

    public Text goalText;

    private void Start()
    {
        titleText.text = quest.questTitle;
        descriptionText.text = quest.questDescription;

        xpText.text = "Reward: " +quest.xpReward.ToString() + " XP";

        goalText.text = quest.goal.goalDescription;     
    }
}
